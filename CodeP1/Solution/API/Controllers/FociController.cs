using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FociController : ControllerBase
    {
        private readonly SocialGoalContext _context;

        public FociController(SocialGoalContext context)
        {
            _context = context;
        }

        // GET: api/Foci
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foci>>> GetFoci()
        {
            return await _context.Foci.ToListAsync();
        }

        // GET: api/Foci/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foci>> GetFoci(int id)
        {
            var foci = await _context.Foci.FindAsync(id);

            if (foci == null)
            {
                return NotFound();
            }

            return foci;
        }

        // PUT: api/Foci/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoci(int id, Foci foci)
        {
            if (id != foci.FocusId)
            {
                return BadRequest();
            }

            _context.Entry(foci).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FociExists(id))
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

        // POST: api/Foci
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Foci>> PostFoci(Foci foci)
        {
            _context.Foci.Add(foci);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoci", new { id = foci.FocusId }, foci);
        }

        // DELETE: api/Foci/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Foci>> DeleteFoci(int id)
        {
            var foci = await _context.Foci.FindAsync(id);
            if (foci == null)
            {
                return NotFound();
            }

            _context.Foci.Remove(foci);
            await _context.SaveChangesAsync();

            return foci;
        }

        private bool FociExists(int id)
        {
            return _context.Foci.Any(e => e.FocusId == id);
        }
    }
}
