using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FociController : ControllerBase
    {
        private readonly SocialGoalDbContext dbcontext;
        public FociController(SocialGoalDbContext _dbcontext) {
            dbcontext = _dbcontext;
        }

        // GET: api/Foci
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foci>>> GetFoci()
        {
            //var res = await new BE.BS.Foci(dbcontext).GetAllAsync();
            //return res.ToList();

            return new BE.BS.Foci(dbcontext).GetAll().ToList();
        }

        // GET: api/Foci/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foci>> GetFoci(int id)
        {
            //var foci = await _context.Foci.FindAsync(id);
            var foci = new BE.BS.Foci(dbcontext).GetOneById(id);

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

            try
            {
                new BE.BS.Foci(dbcontext).Update(foci);
            }
            catch (Exception ee)
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
            new BE.BS.Foci(dbcontext).Insert(foci);

            return CreatedAtAction("GetFoci", new { id = foci.FocusId }, foci);
        }

        //// DELETE: api/Foci/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Foci>> DeleteFoci(int id)
        //{
        //    var foci = await _context.Foci.FindAsync(id);
        //    if (foci == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Foci.Remove(foci);
        //    await _context.SaveChangesAsync();

        //    return foci;
        //}

        private bool FociExists(int id)
        {
            return (new BE.BS.Foci(dbcontext).GetOneById(id) != null);
            //return _context.Foci.Any(e => e.FocusId == id);
        }
    }
}
