using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Context;
using CarRentalApp.Models;
using Microsoft.AspNetCore.Cors;

namespace CarRentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public CityController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/City
        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToArray();
        }

        // GET: api/City/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCity([FromRoute] int id)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = await _context.Cities.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        //  PUT: api/City/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity([FromRoute] int id, [FromBody] City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != city.IDCity)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //  post: api/city
        [HttpPost]
        public async Task<IActionResult> PostCity([FromBody] City city)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getcity", new { id = city.IDCity }, city);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            City c= await _context.Cities.FindAsync(id);
        


            if (c == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(c);
            await _context.SaveChangesAsync();

            return Ok(c);
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.IDCity == id);
        }
    }

}
