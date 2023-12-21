using System;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class StrategyService : IStrategyService
    {
        private readonly IBaseService _baseService;


        public StrategyService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateStrategysAsync(StrategyDto strategyDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = strategyDto,
                Url = SD.StrategyAPIBase + "/api/strategy"
            });
        }

        public async Task<ResponseDto?> DeleteStrategysAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.StrategyAPIBase + "/api/strategy/" + id
            });
        }

        public async Task<ResponseDto?> GetAllStrategysAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.StrategyAPIBase + "/api/strategy"
            });
        }

        public async Task<ResponseDto?> GetStrategyAsync(string strategyCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.StrategyAPIBase + "/api/strategy/GetByName"
            });
        }

        public async Task<ResponseDto?> GetStrategyByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.StrategyAPIBase + "/api/strategy/" + id
            });
        }

        public async Task<ResponseDto?> GetStrategyByNameAsync(string strategyName)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.StrategyAPIBase + "/api/strategy/GetByName" + strategyName
            });
        }

        public async Task<ResponseDto?> UpdateStrategysAsync(StrategyDto strategyDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = strategyDto,
                Url = SD.StrategyAPIBase + "/api/strategy"
            });
        }
    }
}
