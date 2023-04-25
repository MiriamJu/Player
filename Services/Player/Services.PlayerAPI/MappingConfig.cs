using AutoMapper;
using Services.PlayerAPI.Models;
using Services.PlayerAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.PlayerAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PlayerDto, Player>();
                
                config.CreateMap<Player, PlayerDto>()
                   .ForMember(dest => dest.BirthDay, act => act.MapFrom(src => src.BirthStatusAdditionalData.Day))
                   .ForMember(dest => dest.BirthMonth, act => act.MapFrom(src => src.BirthStatusAdditionalData.Month))
                   .ForMember(dest => dest.BirthYear, act => act.MapFrom(src => src.BirthStatusAdditionalData.Year))
                   .ForMember(dest => dest.BirthCity, act => act.MapFrom(src => src.BirthStatusAdditionalData.City))
                   .ForMember(dest => dest.BirthCountry, act => act.MapFrom(src => src.BirthStatusAdditionalData.Country))
                   .ForMember(dest => dest.BirthState, act => act.MapFrom(src => src.BirthStatusAdditionalData.State))
                   .ForMember(dest => dest.DeathDay, act => act.MapFrom(src => src.DeathStatusAdditionalData.Day))
                   .ForMember(dest => dest.DeathMonth, act => act.MapFrom(src => src.DeathStatusAdditionalData.Month))
                   .ForMember(dest => dest.DeathYear, act => act.MapFrom(src => src.DeathStatusAdditionalData.Year))
                   .ForMember(dest => dest.DeathCity, act => act.MapFrom(src => src.DeathStatusAdditionalData.City))
                   .ForMember(dest => dest.DeathCountry, act => act.MapFrom(src => src.DeathStatusAdditionalData.Country))
                   .ForMember(dest => dest.DeathState, act => act.MapFrom(src => src.DeathStatusAdditionalData.State));
            });

            return mappingConfig;
        }
    }
}
