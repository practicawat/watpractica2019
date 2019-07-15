using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Context;
using CarRentalApp.Models;

namespace CarRentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CityController(CarDbContext context)
        {
            _context = context;
        }

        // GET: api/City
        [HttpGet]
        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToArray();
        }

        // GET: api/City/5
        [HttpGet("{IDCity}")]
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
        [HttpPut("{IDCity}")]
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
        public async Task<IActionResult> PostCity([FromBody] FormCollection collection)
        {
            int id = Int32.Parse(collection["IDCity"]);
            string name = collection["CityName"];
            string nameCounty = collection["CountyName"];
            City city = new City(id, name, nameCounty);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getcity", new { id = city.IDCity }, city);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{IDCity}")]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
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

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return Ok(city);
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.IDCity == id);
        }
    }

}
