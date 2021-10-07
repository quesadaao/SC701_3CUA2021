using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objects;

namespace BE.DAL.Repository
{
    public interface IRepositoryFoci : IRepository<data.Foci>
    {
        Task<IEnumerable<data.Foci>> GetAllAsync();
        Task<data.Foci> GetOneByIdAsync(int id);
    }
}
