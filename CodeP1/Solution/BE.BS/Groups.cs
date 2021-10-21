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

    public class Groups : ICRUD<data.Groups>
    {
        private dal.Groups _dal;
        public Groups(SocialGoalDbContext dbContext)
        {
            _dal = new dal.Groups(dbContext);
        }
        public void Delete(data.Groups t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Groups> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Groups>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Groups GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Groups> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.Groups t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Groups t)
        {
            _dal.Update(t);
        }
    }
}
