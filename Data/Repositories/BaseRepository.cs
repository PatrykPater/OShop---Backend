using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        private readonly DBContext _dBContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = _dBContext.Set<T>();
        }

        public virtual async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task<T> GetByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual void Delete(T entity)
        {
             _dbSet.Remove(entity);
        }

        public virtual void DeleteRange(List<T> entities)
        {
             _dbSet.RemoveRange(entities);
        }

        public virtual async Task<T> Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public virtual IQueryable<T> Table()
        {
            return _dbSet;
        }
    }
}
