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
    public class ProcedimientosController : ControllerBase
    {
        private readonly HospitalDbContext _context;

        public ProcedimientosController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: api/Procedimientos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Procedimiento>>> GetProcedimientos()
        {
            return await _context.Procedimientos.ToListAsync();
        }

        // GET: api/Procedimientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Procedimiento>> GetProcedimiento(int id)
        {
            var procedimiento = await _context.Procedimientos.FindAsync(id);

            if (procedimiento == null)
            {
                return NotFound();
            }

            return procedimiento;
        }

        // PUT: api/Procedimientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProcedimiento(int id, Procedimiento procedimiento)
        {
            if (id != procedimiento.ProcedimientoID)
            {
                return BadRequest();
            }

            _context.Entry(procedimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcedimientoExists(id))
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

        // POST: api/Procedimientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Procedimiento>> PostProcedimiento(Procedimiento procedimiento)
        {
            _context.Procedimientos.Add(procedimiento);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProcedimientoExists(procedimiento.ProcedimientoID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProcedimiento", new { id = procedimiento.ProcedimientoID }, procedimiento);
        }

        // DELETE: api/Procedimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProcedimiento(int id)
        {
            var procedimiento = await _context.Procedimientos.FindAsync(id);
            if (procedimiento == null)
            {
                return NotFound();
            }

            _context.Procedimientos.Remove(procedimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProcedimientoExists(int id)
        {
            return _context.Procedimientos.Any(e => e.ProcedimientoID == id);
        }
    }
}
