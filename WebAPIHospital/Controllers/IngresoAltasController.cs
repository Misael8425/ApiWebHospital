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
    public class IngresoAltasController : ControllerBase
    {
        private readonly HospitalDbContext _context;

        public IngresoAltasController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: api/IngresoAltas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngresoAlta>>> GetIngresoAltas()
        {
            return await _context.IngresoAltas.ToListAsync();
        }

        // GET: api/IngresoAltas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngresoAlta>> GetIngresoAlta(int id)
        {
            var ingresoAlta = await _context.IngresoAltas.FindAsync(id);

            if (ingresoAlta == null)
            {
                return NotFound();
            }

            return ingresoAlta;
        }

        // PUT: api/IngresoAltas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngresoAlta(int id, IngresoAlta ingresoAlta)
        {
            if (id != ingresoAlta.IngresoAltaID)
            {
                return BadRequest();
            }

            _context.Entry(ingresoAlta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngresoAltaExists(id))
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

        // POST: api/IngresoAltas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IngresoAlta>> PostIngresoAlta(IngresoAlta ingresoAlta)
        {
            _context.IngresoAltas.Add(ingresoAlta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngresoAlta", new { id = ingresoAlta.IngresoAltaID }, ingresoAlta);
        }

        // DELETE: api/IngresoAltas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngresoAlta(int id)
        {
            var ingresoAlta = await _context.IngresoAltas.FindAsync(id);
            if (ingresoAlta == null)
            {
                return NotFound();
            }

            _context.IngresoAltas.Remove(ingresoAlta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngresoAltaExists(int id)
        {
            return _context.IngresoAltas.Any(e => e.IngresoAltaID == id);
        }
    }
}
