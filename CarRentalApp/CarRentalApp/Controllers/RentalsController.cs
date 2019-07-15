using CarRentalApp.Context;
using CarRentalApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly CarDbContext _context;

        public RentalsController(CarDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Rentals> GetRentals()
        {
            return _context.Rentals.ToArray();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRentals([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rentals = await _context.Rentals.FindAsync(id);

            if (rentals == null)
            {
                return NotFound();
            }

            return Ok(rentals);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentals([FromRoute] int id, [FromBody] Rentals rentals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rentals.RentalsId)
            {
                return BadRequest();
            }

            _context.Entry(rentals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentalsExists(id))
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

        // POST: api/ars
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] Rentals rentals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Rentals.Add(rentals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentals", new { id = rentals.RentalsId }, rentals);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rentals = await _context.Rentals.FindAsync(id);
            if (rentals == null)
            {
                return NotFound();
            }

            _context.Rentals.Remove(rentals);
            await _context.SaveChangesAsync();

            return Ok(rentals);
        }

        private bool RentalsExists(int id)
        {
            return _context.Rentals.Any(e => e.RentalsId == id);
        }
    }
}
