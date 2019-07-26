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
    public class ImagesController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public ImagesController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/Images
        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Images> GetCities()
        {
            return _context.Images.ToArray();
        }

        // GET: api/Images/ceva
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImages([FromRoute] int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var image = await _context.Images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return Ok();
        }

        //  PUT: api/Images/ceva
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImages([FromRoute] int id, [FromBody] Images image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != image.Id)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagesExists(id))
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

        //  post: api/Images
        [HttpPost]
        public async Task<IActionResult> PostImages([FromBody] Images image)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getimage", new { id = image.Id }, image);
        }

        // DELETE: api/Images/ceva
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImages([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Images c = await _context.Images.FindAsync(id);



            if (c == null)
            {
                return NotFound();
            }

            _context.Images.Remove(c);
            await _context.SaveChangesAsync();

            return Ok(c);
        }

        private bool ImagesExists(int id)
        {
            return _context.Images.Any(e => e.Id == id);
        }
    }

}
