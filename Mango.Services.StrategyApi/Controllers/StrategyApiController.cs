using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mango.Services.StrategyApi.Controllers
{
    [Route("api/[controller]")]
    public class StrategyApiController : Controller
    {
        private readonly Data.AppDbContext _db;
        public StrategyApiController(Data.AppDbContext db)
        {
            _db = db;
        }

        // GET: api/values
        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Models.Strategy> objList = _db.Strategies.ToList();
                return objList;
            }
            catch (Exception ex)
            {
                
            }

            return null;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            try
            {
                Models.Strategy obj = _db.Strategies.First(u=>u.Id== id);
                return obj;
            }
            catch (Exception ex)
            {

            }

            return null;
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

