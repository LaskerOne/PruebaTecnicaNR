using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/UsersBCcont")]
    [ApiController]
    public class UsersBCcont : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UsersBCcont(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/UsersBCcont
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersBC>>> GetUsersBC()
        {
            return await _context.UsersBC.ToListAsync();
        }

        // GET: api/UsersBCcont/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsersBC>> GetUsersBC(int id)
        {
            var usersBC = await _context.UsersBC.FindAsync(id);

            if (usersBC == null)
            {
                return NotFound();
            }

            return usersBC;
        }

        // PUT: api/UsersBCcont/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsersBC(int id, UsersBC usersBC)
        {
            if (id != usersBC.Id)
            {
                return BadRequest();
            }

            _context.Entry(usersBC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersBCExists(id))
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

        // POST: api/UsersBCcont
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsersBC>> PostUsersBC(UsersBC usersBC)
        {
            _context.UsersBC.Add(usersBC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsersBC", new { id = usersBC.Id }, usersBC);
        }

        // DELETE: api/UsersBCcont/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsersBC(int id)
        {
            var usersBC = await _context.UsersBC.FindAsync(id);
            if (usersBC == null)
            {
                return NotFound();
            }

            _context.UsersBC.Remove(usersBC);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsersBCExists(int id)
        {
            return _context.UsersBC.Any(e => e.Id == id);
        }
    }
}
