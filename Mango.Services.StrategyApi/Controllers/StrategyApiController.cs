using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mango.Services.StrategyApi.Models;
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
        private IMapper _mapper;

        public StrategyApiController(Data.AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        // GET: api/values
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Models.Strategy> objList = _db.Strategies.ToList();
                _response.Resault = _mapper.Map<IEnumerable<StrategyDto>>(objList);
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
                _response.Resault = _mapper.Map<StrategyDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }


        // GET api/values/GetByName/
        // имя или код(код в сервисе на фронте)
        [HttpGet]
        [Route("GetByName/{name}")] 
        public ResponseDto GetByName(string name)
        {
            try
            {
                Models.Strategy obj = _db.Strategies.First(u => u.Name.ToLower() == name.ToLower());
                _response.Resault = _mapper.Map<StrategyDto>(obj);
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
        public ResponseDto Post([FromBody]StrategyDto strategyDto)
        {
            try
            {
                Strategy obj = _mapper.Map<Strategy>(strategyDto);
                _db.Strategies.Add(obj);
                _db.SaveChanges();

                _response.Resault = _mapper.Map<StrategyDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        // PUT api/values/5
        [HttpPut]
        public ResponseDto Put([FromBody] StrategyDto strategyDto)
        {
            try
            {
                Strategy obj = _mapper.Map<Strategy>(strategyDto);
                _db.Strategies.Update(obj);
                _db.SaveChanges();

                _response.Resault = _mapper.Map<StrategyDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        // DELETE api/values/5
        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Strategy obj =_db.Strategies.First(u => u.Id == id);
                _db.Strategies.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }
    }
}