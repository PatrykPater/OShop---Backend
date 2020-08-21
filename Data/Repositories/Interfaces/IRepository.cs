using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> GetByID(int id);
        Task<List<T>> GetAll();
        void Delete(T entity);
        void DeleteRange(List<T> entities);
        Task<T> Update(T entity);
        IQueryable<T> Table();
    }
}
