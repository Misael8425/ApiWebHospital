﻿using System;
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
    public class AutorizacionesController : ControllerBase
    {
        private readonly HospitalDbContext _context;

        public AutorizacionesController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: api/Autorizaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autorizacion>>> GetAutorizaciones()
        {
            return await _context.Autorizaciones.ToListAsync();
        }

        // GET: api/Autorizaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autorizacion>> GetAutorizacion(int id)
        {
            var autorizacion = await _context.Autorizaciones.FindAsync(id);

            if (autorizacion == null)
            {
                return NotFound();
            }

            return autorizacion;
        }

        // PUT: api/Autorizaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutorizacion(int id, Autorizacion autorizacion)
        {
            if (id != autorizacion.AutorizacionID)
            {
                return BadRequest();
            }

            _context.Entry(autorizacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutorizacionExists(id))
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

        // POST: api/Autorizaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Autorizacion>> PostAutorizacion(Autorizacion autorizacion)
        {
            _context.Autorizaciones.Add(autorizacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutorizacion", new { id = autorizacion.AutorizacionID }, autorizacion);
        }

        // DELETE: api/Autorizaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutorizacion(int id)
        {
            var autorizacion = await _context.Autorizaciones.FindAsync(id);
            if (autorizacion == null)
            {
                return NotFound();
            }

            _context.Autorizaciones.Remove(autorizacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutorizacionExists(int id)
        {
            return _context.Autorizaciones.Any(e => e.AutorizacionID == id);
        }
    }
}
