using System;
using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
	public class StrategyService:IStrategyService
	{
		private readonly IBaseService _baseService;


		public StrategyService(IBaseService baseService)
		{
			_baseService = baseService;
		}

        public Task<ResponseDto?> CreateStrategysAsync(StrategyDto strategyDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteStrategysAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetAllStrategysAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetStrategyAsync(string strategyCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetStrategyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetStrategyByNameAsync(string strategyName)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateStrategysAsync(StrategyDto strategyDto)
        {
            throw new NotImplementedException();
        }
    }
}

