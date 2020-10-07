using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNET.Data;
using ASPNET.Models;

namespace ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorSetController : ControllerBase
    {
        private readonly ProyectoWinFormContext _context;

        public AutorSetController(ProyectoWinFormContext context)
        {
            _context = context;
        }

        // GET: api/AutorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutorSet>>> GetAutorSet()
        {
            return await _context.AutorSet.ToListAsync();
        }

        // GET: api/AutorSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AutorSet>> GetAutorSet(int id)
        {
            var autorSet = await _context.AutorSet.FindAsync(id);

            if (autorSet == null)
            {
                return NotFound();
            }

            return autorSet;
        }

        // PUT: api/AutorSet/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutorSet(int id, AutorSet autorSet)
        {
            if (id != autorSet.AutorId)
            {
                return BadRequest();
            }

            _context.Entry(autorSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutorSetExists(id))
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

        // POST: api/AutorSet
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AutorSet>> PostAutorSet(AutorSet autorSet)
        {
            _context.AutorSet.Add(autorSet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutorSet", new { id = autorSet.AutorId }, autorSet);
        }

        // DELETE: api/AutorSet/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AutorSet>> DeleteAutorSet(int id)
        {
            var autorSet = await _context.AutorSet.FindAsync(id);
            if (autorSet == null)
            {
                return NotFound();
            }

            _context.AutorSet.Remove(autorSet);
            await _context.SaveChangesAsync();

            return autorSet;
        }

        private bool AutorSetExists(int id)
        {
            return _context.AutorSet.Any(e => e.AutorId == id);
        }
    }
}
