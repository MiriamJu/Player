using Services.PlayerAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PlayerAPI.Repository
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<PlayerDto>> GetPlayers();
        Task<PlayerDto> GetPlayerById(string playerId);
    }
}
