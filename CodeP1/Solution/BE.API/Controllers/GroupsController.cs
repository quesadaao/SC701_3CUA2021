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
    public class GroupsController : ControllerBase
    {
        private readonly SocialGoalDbContext dbcontext;
        private readonly IMapper mapper;
        public GroupsController(SocialGoalDbContext _dbcontext, IMapper _mapper)
        {
            dbcontext = _dbcontext;
            mapper = _mapper;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Groups>>> GetGroups()
        {
            var res = new BE.BS.Groups(dbcontext).GetAll();
            var mapaux = mapper.Map<IEnumerable<data.Groups>,IEnumerable<models.Groups>>(res).ToList();
            return mapaux;
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Groups>> GetGroups(int id)
        {
            var groups = new BE.BS.Groups(dbcontext).GetOneById(id);

            if (groups == null)
            {
                return NotFound();
            }
            var mapaux = mapper.Map<data.Groups, models.Groups>(groups);
            return mapaux;
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroups(int id, models.Groups groups)
        {
            if (id != groups.GroupId)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = mapper.Map<models.Groups, data.Groups>(groups);
                new BE.BS.Groups(dbcontext).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!GroupsExists(id))
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

        // POST: api/Groups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Groups>> PostGroups(models.Groups groups)
        {
            var mapaux = mapper.Map<models.Groups, data.Groups>(groups);
            new BE.BS.Groups(dbcontext).Insert(mapaux);

            return CreatedAtAction("GetGroups", new { id = groups.GroupId }, groups);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Groups>> DeleteGroups(int id)
        {
            var groups = new BE.BS.Groups(dbcontext).GetOneById(id);
            if (groups == null)
            {
                return NotFound();
            }

            new BE.BS.Groups(dbcontext).Delete(groups);
            var mapaux = mapper.Map<data.Groups, models.Groups>(groups);
            return mapaux;
        }

        private bool GroupsExists(int id)
        {
            return (new BE.BS.Groups(dbcontext).GetOneById(id) != null);
        }
    }
}
