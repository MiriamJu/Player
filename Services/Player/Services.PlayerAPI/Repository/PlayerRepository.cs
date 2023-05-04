using AutoMapper;
using Services.PlayerAPI.DbContexts;
using Services.PlayerAPI.Models;
using Services.PlayerAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PlayerAPI.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public PlayerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<PlayerDto> GetPlayerById(string playerId)
        {
            using (ApplicationDbContext context = _db)
            {
                Player product = await _db.Players.Where(x => string.Equals(x.PlayerId, playerId)).FirstOrDefaultAsync(); ;
                return _mapper.Map<PlayerDto>(product);
            }
          
        }

        public async Task<IEnumerable<PlayerDto>> GetPlayers()
        {
            using (ApplicationDbContext context = _db)
            {
                List<Player> productList = await _db.Players.Include(b => b.BirthStatusAdditionalData).Include(d => d.DeathStatusAdditionalData).Take(20).ToListAsync();
                return _mapper.Map<List<PlayerDto>>(productList);
            }
        }
    }
}
