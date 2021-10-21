using AutoMapper;
using data = BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using models = BE.API.Models;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FociController : ControllerBase
    {
        private readonly SocialGoalDbContext dbcontext;
        private readonly IMapper mapper;
        public FociController(SocialGoalDbContext _dbcontext, IMapper _mapper) {
            dbcontext = _dbcontext;
            mapper = _mapper;
        }

        // GET: api/Foci
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Foci>>> GetFoci()
        {
            var res = await new BE.BS.Foci(dbcontext).GetAllAsync();
            var mapaux = mapper.Map<IEnumerable<data.Foci>, IEnumerable<models.Foci>>(res).ToList();

            return mapaux;

            // Este GetAll no trae las relaaciones
            //return new BE.BS.Foci(dbcontext).GetAll().ToList();
        }

        // GET: api/Foci/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Foci>> GetFoci(int id)
        {
            var foci = await new BE.BS.Foci(dbcontext).GetOneByIdAsync(id);
            var mapaux = mapper.Map<data.Foci, models.Foci>(foci);

            // Este Get no trae las relaaciones
            //var foci = new BE.BS.Foci(dbcontext).GetOneById(id);

            if (foci == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Foci/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoci(int id, models.Foci foci)
        {
            if (id != foci.FocusId)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = mapper.Map<models.Foci, data.Foci>(foci);
                new BE.BS.Foci(dbcontext).Update(mapaux);
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
        public async Task<ActionResult<models.Foci>> PostFoci(models.Foci foci)
        {
            var mapaux = mapper.Map<models.Foci, data.Foci>(foci);
            new BE.BS.Foci(dbcontext).Insert(mapaux);

            return CreatedAtAction("GetFoci", new { id = foci.FocusId }, foci);
        }

        // DELETE: api/Foci/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Foci>> DeleteFoci(int id)
        {
            var foci = new BE.BS.Foci(dbcontext).GetOneById(id);
            if (foci == null)
            {
                return NotFound();
            }

            new BE.BS.Foci(dbcontext).Delete(foci);
            var mapaux = mapper.Map<data.Foci,models.Foci>(foci);
            return mapaux;
        }

        private bool FociExists(int id)
        {
            return (new BE.BS.Foci(dbcontext).GetOneById(id) != null);
            //return _context.Foci.Any(e => e.FocusId == id);
        }
    }
}
