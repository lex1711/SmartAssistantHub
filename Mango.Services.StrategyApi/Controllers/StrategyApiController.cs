using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Services.StrategyApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mango.Services.StrategyApi.Controllers
{
    [Route("api/[controller]")]
    public class StrategyApiController : Controller
    {
        private readonly Data.AppDbContext _db;
        private ResponseDto _response;

        public StrategyApiController(Data.AppDbContext db)
        {
            _db = db;
            _response = new ResponseDto();
        }

        // GET: api/values
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Models.Strategy> objList = _db.Strategies.ToList();
                _response.Resault = objList;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Models.Strategy obj = _db.Strategies.First(u=>u.Id== id);
                StrategyDto strategyDto = new StrategyDto()
                {
                    Id = obj.Id,
                    Description = obj.Description,
                    Name = obj.Name,
                    RecommendedFor = obj.RecommendedFor,
                    Categories = obj.Categories,
                    ComplexityLevel = obj.ComplexityLevel,
                    CreatedAt = obj.CreatedAt,
                    IsAIEnhanced = obj.IsAIEnhanced,
                    Resources = obj.Resources,
                    Tags = obj.Tags,
                    UpdatedAt = obj.UpdatedAt
                };
                _response.Resault = strategyDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

