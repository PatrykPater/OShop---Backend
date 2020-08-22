using Data.Repositories.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository :  IProductRepository
    {
        private readonly DBContext _dBContext;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = _dBContext.Set<Product>();
        }

        public virtual async Task<Product> Add(Product entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task<Product> GetByID(int id)
        {
            return await _dbSet.Include(p => p.Category)
                               .FirstOrDefaultAsync(p => p.Id == id);
        }

        public virtual async Task<List<Product>> GetAll()
        {
            return await _dbSet.Include(p => p.Category)
                               .ToListAsync();
        }

        public virtual void Delete(Product entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void DeleteRange(List<Product> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public Product Update(Product entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public virtual IQueryable<Product> Table()
        {
            return _dbSet;
        }
    }
}
