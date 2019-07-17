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
    public class CarsController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public CarsController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
                return _context.Cars.ToArray();
        }

        // GET: api/Cars/5
        [HttpGet("{licensePlate}")]
        public async Task<IActionResult> GetCar([FromRoute] string licensePlate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FindAsync(licensePlate);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        // PUT: api/Cars/5
        [HttpPut("{licensePlate}")]
        public async Task<IActionResult> PutCar([FromRoute] string licensePlate, [FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (licensePlate != car.LicensePlate)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(licensePlate))
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

        // POST: api/Cars
        [HttpPost]
        public async Task<IActionResult> PostCar([FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { licensePlate = car.LicensePlate }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{licensePlate}")]
        public async Task<IActionResult> DeleteCar([FromRoute] string licensePlate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FindAsync(licensePlate);
            if (car == null)
            {   
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return Ok(car);
        }

        private bool CarExists(string licensePlate)
        {
            return _context.Cars.Any(e => e.LicensePlate == licensePlate);
        }
    }
}