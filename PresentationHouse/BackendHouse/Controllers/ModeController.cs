using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationHouse.Contracts;
using DomainHouse.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendHouse.Controllers
{
    [Route("api/[controller]")]
    public class ModeController : Controller
    {

        private readonly IMode _mode;

        public ModeController(IMode mode)
        {
            _mode = mode;
        }


        // GET: api/<ModeController>/
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var data = await _mode.GetAllAsync();
            return Ok(data);
        }

        //TO DO

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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

