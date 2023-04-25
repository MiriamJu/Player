using AutoMapper;
using Services.ProductAPI.DbContexts;
using Services.ProductAPI.Models;
using Services.ProductAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Repository
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
            Player product = await _db.Players.Where(x=>string.Equals(x.PlayerId, playerId)).FirstOrDefaultAsync(); ;
            return _mapper.Map<PlayerDto>(product);
        }

        public async Task<IEnumerable<PlayerDto>> GetPlayers()
        {
            List<Player> productList = await _db.Players.ToListAsync();
            return _mapper.Map<List<PlayerDto>>(productList);

        }
    }
}
