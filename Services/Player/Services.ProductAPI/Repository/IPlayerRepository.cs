using Services.ProductAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ProductAPI.Repository
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<PlayerDto>> GetPlayers();
        Task<PlayerDto> GetPlayerById(string playerId);
    }
}
