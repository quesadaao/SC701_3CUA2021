using BE.DAL.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;
using dal = BE.DAL;
using BE.DAL.EF;

namespace BE.BS
{
    public class Foci : ICRUD<data.Foci>
    {
        private dal.Foci _dal;
        public Foci(SocialGoalDbContext dbContext) {
            _dal = new dal.Foci(dbContext);
        }
        public void Delete(data.Foci t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Foci> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Foci>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Foci GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Foci> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.Foci t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Foci t)
        {
            _dal.Update(t);
        }
    }
}
