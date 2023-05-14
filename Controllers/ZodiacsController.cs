using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atv1Astrologia.Model;

namespace Atv1Astrologia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZodiacsController : ControllerBase
    {
        private readonly ZodiacContext _context;

        public ZodiacsController(ZodiacContext context)
        {
            _context = context;
        }

        // GET: api/Zodiacs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zodiac>>> GetCriptoCoinItens()
        {
          if (_context.CriptoCoinItens == null)
          {
              return NotFound();
          }
            return await _context.CriptoCoinItens.ToListAsync();
        }

        // GET: api/Zodiacs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zodiac>> GetZodiac(int id)
        {
          if (_context.CriptoCoinItens == null)
          {
              return NotFound();
          }
            var zodiac = await _context.CriptoCoinItens.FindAsync(id);

            if (zodiac == null)
            {
                return NotFound();
            }

            return zodiac;
        }

        // PUT: api/Zodiacs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZodiac(int id, Zodiac zodiac)
        {
            if (id != zodiac.Id)
            {
                return BadRequest();
            }

            _context.Entry(zodiac).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZodiacExists(id))
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

        // POST: api/Zodiacs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Zodiac>> PostZodiac(Zodiac zodiac)
        {
          if (_context.CriptoCoinItens == null)
          {
              return Problem("Entity set 'ZodiacContext.CriptoCoinItens'  is null.");
          }
            _context.CriptoCoinItens.Add(zodiac);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZodiac", new { id = zodiac.Id }, zodiac);
        }

        // DELETE: api/Zodiacs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZodiac(int id)
        {
            if (_context.CriptoCoinItens == null)
            {
                return NotFound();
            }
            var zodiac = await _context.CriptoCoinItens.FindAsync(id);
            if (zodiac == null)
            {
                return NotFound();
            }

            _context.CriptoCoinItens.Remove(zodiac);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZodiacExists(int id)
        {
            return (_context.CriptoCoinItens?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
