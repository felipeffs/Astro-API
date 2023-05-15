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
    public class ZodiacProfilesController : ControllerBase
    {
        private readonly ZodiacProfileContext _context;

        public ZodiacProfilesController(ZodiacProfileContext context)
        {
            _context = context;
        }

        // GET: api/ZodiacProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZodiacProfile>>> GetZodiacProfiles()
        {
          if (_context.ZodiacProfiles == null)
          {
              return NotFound();
          }
            return await _context.ZodiacProfiles.ToListAsync();
        }

        // GET: api/ZodiacProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZodiacProfile>> GetZodiacProfile(int id)
        {
          if (_context.ZodiacProfiles == null)
          {
              return NotFound();
          }
            var zodiacProfile = await _context.ZodiacProfiles.FindAsync(id);

            if (zodiacProfile == null)
            {
                return NotFound();
            }

            return zodiacProfile;
        }

        // PUT: api/ZodiacProfiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZodiacProfile(int id, ZodiacProfile zodiacProfile)
        {
            if (id != zodiacProfile.Id)
            {
                return BadRequest();
            }

            _context.Entry(zodiacProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZodiacProfileExists(id))
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

        // POST: api/ZodiacProfiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ZodiacProfile>> PostZodiacProfile(ZodiacProfile zodiacProfile)
        {
          if (_context.ZodiacProfiles == null)
          {
              return Problem("Entity set 'ZodiacProfileContext.ZodiacProfiles'  is null.");
          }
            _context.ZodiacProfiles.Add(zodiacProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZodiacProfile", new { id = zodiacProfile.Id }, zodiacProfile);
        }

        // DELETE: api/ZodiacProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZodiacProfile(int id)
        {
            if (_context.ZodiacProfiles == null)
            {
                return NotFound();
            }
            var zodiacProfile = await _context.ZodiacProfiles.FindAsync(id);
            if (zodiacProfile == null)
            {
                return NotFound();
            }

            _context.ZodiacProfiles.Remove(zodiacProfile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZodiacProfileExists(int id)
        {
            return (_context.ZodiacProfiles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
