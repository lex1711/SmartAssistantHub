using System;
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
	public interface IStrategyService
	{
        //look controller params
        Task<ResponseDto?> GetStrategyAsync(string strategyCode);
		Task<ResponseDto?> GetAllStrategysAsync();
        Task<ResponseDto?> GetStrategyByIdAsync( int id);
        Task<ResponseDto?> GetStrategyByNameAsync(string strategyName);
        Task<ResponseDto?> CreateStrategysAsync(StrategyDto strategyDto);
        Task<ResponseDto?> UpdateStrategysAsync(StrategyDto strategyDto);
        Task<ResponseDto?> DeleteStrategysAsync(int id);
    }
}

