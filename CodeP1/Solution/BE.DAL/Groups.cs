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
    public class Groups : ICRUD<data.Groups>
    {
        private Repository<data.Groups> repo;
        public Groups(SocialGoalDbContext dbContext)
        {
            repo = new Repository<data.Groups>(dbContext);
        }
        public void Delete(data.Groups t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Groups> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Groups>> GetAllAsync()
        {
            return null;
        }

        public data.Groups GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Groups> GetOneByIdAsync(int id)
        {
            return null;
        }

        public void Insert(data.Groups t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Groups t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
