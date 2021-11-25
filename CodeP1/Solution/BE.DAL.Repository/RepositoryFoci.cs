using BE.DAL.DO.Objects;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public class RepositoryFoci : Repository<data.Foci>, IRepositoryFoci
    {

        public RepositoryFoci(SocialGoalDbContext _dbContext): base(_dbContext) { 
        
        }
        public async Task<IEnumerable<Foci>> GetAllAsync()
        {
            return await _db.Foci
                .Include(m => m.Group)
                .ToListAsync();
        }

        public async Task<Foci> GetOneByIdAsync(int id)
        {
            return await _db.Foci
                .Include(m => m.Group)
                .SingleOrDefaultAsync(m => m.FocusId == id);
        }
        private SocialGoalDbContext _db {
            get { return dbContext as SocialGoalDbContext; }
        }
    }
}
