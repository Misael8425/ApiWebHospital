using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIHospital.Context;
using WebAPIHospital.Models;

namespace WebAPIHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalisisController : ControllerBase
    {
        private readonly HospitalDbContext _context;

        public AnalisisController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: api/Analisis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Analisis>>> GetAnalisis()
        {
            return await _context.Analisis.ToListAsync();
        }

        // GET: api/Analisis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Analisis>> GetAnalisis(int id)
        {
            var analisis = await _context.Analisis.FindAsync(id);

            if (analisis == null)
            {
                return NotFound();
            }

            return analisis;
        }

        // PUT: api/Analisis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnalisis(int id, Analisis analisis)
        {
            if (id != analisis.AnalisisID)
            {
                return BadRequest();
            }

            _context.Entry(analisis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnalisisExists(id))
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

        // POST: api/Analisis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Analisis>> PostAnalisis(Analisis analisis)
        {
            _context.Analisis.Add(analisis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnalisis", new { id = analisis.AnalisisID }, analisis);
        }

        // DELETE: api/Analisis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnalisis(int id)
        {
            var analisis = await _context.Analisis.FindAsync(id);
            if (analisis == null)
            {
                return NotFound();
            }

            _context.Analisis.Remove(analisis);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnalisisExists(int id)
        {
            return _context.Analisis.Any(e => e.AnalisisID == id);
        }
    }
}
