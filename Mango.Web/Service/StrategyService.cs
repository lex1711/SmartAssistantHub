using System;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
	public class StrategyService:IStrategyService
	{
		private readonly IBaseService _baseService;


		public StrategyService(IBaseService baseService)
		{
			_baseService = baseService;
		}

        public async Task<ResponseDto?> CreateStrategysAsync(StrategyDto strategyDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> DeleteStrategysAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllStrategysAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType=SD.ApiType.GET,
                Url = SD.StrategyAPIBase+"/api/strategy"
            });
        }

        public async Task<ResponseDto?> GetStrategyAsync(string strategyCode)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetStrategyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetStrategyByNameAsync(string strategyName)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateStrategysAsync(StrategyDto strategyDto)
        {
            throw new NotImplementedException();
        }
    }
}

