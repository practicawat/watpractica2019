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
    public class InfoUserController : ControllerBase
    {
        private readonly CarDbContext _context;

        public InfoUserController(CarDbContext context)
        {
            _context = context;
        }
        // GET: api/InfoUser
        [HttpGet]
        public IEnumerable<InfoUser> GetInfoUsers()
        {
            return _context.InfoUsers.ToArray();
        }

        // GET: api/InfoUser/5
        [HttpGet("{ID_user}")]
        public async Task<IActionResult> GeInfoUsers([FromRoute] int ID_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var infousers = await _context.InfoUsers.FindAsync(ID_user);

            if (infousers == null)
            {
                return NotFound();
            }

            return Ok(infousers);
        }

        // PUT: api/InfoUser/5
        [HttpPut("{ID_user}")]
        public async Task<IActionResult> PutInfoUsers([FromRoute] int id, [FromBody] InfoUser infoUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != infoUser.ID_user)
            {
                return BadRequest();
            }

            _context.Entry(infoUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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
        public async Task<IActionResult> PostInfoUser([FromBody] InfoUser infoUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InfoUsers.Add(infoUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInfoUser", new { id = infoUser.ID_user }, infoUser);
        }

        // DELETE: api/InfoUser/5
        [HttpDelete("{ID_user }")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.InfoUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.InfoUsers.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private bool UserExists(int id)
        {
            return _context.InfoUsers.Any(e => e.ID_user == id);
        }
    }
}
