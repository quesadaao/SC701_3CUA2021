using data = BE.DAL.DO.Objects;
using BE.DAL.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE.DAL.Repository;
using BE.DAL.EF;

namespace BE.DAL
{
    public class Foci : ICRUD<data.Foci>
    {
        private RepositoryFoci repo;
        public Foci(SocialGoalDbContext dbContext) {
            repo = new RepositoryFoci(dbContext);
        }
        public void Delete(data.Foci t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Foci> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Foci>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Foci GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Foci> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Foci t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Foci t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
