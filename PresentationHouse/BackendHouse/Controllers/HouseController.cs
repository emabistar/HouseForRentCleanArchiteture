using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationHouse.Contracts;
using ApplicationHouse.Dtos;
using DomainHouse.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouse _house;
        public HouseController(IHouse house)
        {
            _house = house;
        }


        // GET: api/<HouseController>/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _house.GetAllHouseAsync();
            return Ok(data);
        }

        // GET api/<HouseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _house.GetHouseByIdAsync(id);
            return Ok(data);
        }

        // POST api/<HouseController>/
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] House houseDto)
        {
            var ressult = await _house.CreateHouseAsync(houseDto);
            return Ok(ressult);
        }

        // PUT api/<HouseController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult>Put(int id, [FromBody] House houseDto)
        {
            var ressult = await _house.UpdateHouseAsync(houseDto);
            return Ok(ressult);
        }

        // DELETE api/<HouseController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _house.DeleteHouseAsync(id);
            return Ok(result);
        }
    }
}

