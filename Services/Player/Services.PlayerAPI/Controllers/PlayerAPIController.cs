using Services.PlayerAPI.Models.Dto;
using Services.PlayerAPI.Models.Dtos;
using Services.PlayerAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PlayerAPI.Controllers
{
    [Route("api/players")]
    public class PlayerAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IPlayerRepository _playerRepository;

        public PlayerAPIController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
            this._response = new ResponseDto();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<PlayerDto> playerDtos = await _playerRepository.GetPlayers();
                _response.Result = playerDtos;
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(string id)
        {
            try
            {
                PlayerDto playerDto = await _playerRepository.GetPlayerById(id);
                _response.Result = playerDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
