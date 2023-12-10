using System;
using AutoMapper;
using Mango.Services.StrategyApi.Models;
using Mango.Services.StrategyApi.Models.Dto;

namespace Mango.Services.StrategyApi
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<StrategyDto, Strategy>();
                config.CreateMap<Strategy, StrategyDto>();
            });
			return mappingConfig;
        }
		public MappingConfig()
		{
		}
	}
}

