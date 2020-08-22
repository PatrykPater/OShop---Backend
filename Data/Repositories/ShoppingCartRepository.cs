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
    public class ShoppingCartRepository: IShoppingCartRepository
    {
        private readonly DBContext _dBContext;
        private readonly DbSet<ShoppingCart> _dbSet;
        
        public ShoppingCartRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = _dBContext.Set<ShoppingCart>();
        }

        public virtual async Task<ShoppingCart> Add(ShoppingCart entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task<ShoppingCart> GetByID(int id)
        {
            return await _dbSet.Include(p => p.CartItems)
                               .FirstOrDefaultAsync(p => p.Id == id);
        }

        public virtual async Task<List<ShoppingCart>> GetAll()
        {
            return await _dbSet.Include(p => p.CartItems)
                               .ToListAsync();
        }

        public virtual void Delete(ShoppingCart entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void DeleteRange(List<ShoppingCart> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public ShoppingCart Update(ShoppingCart entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public virtual IQueryable<ShoppingCart> Table()
        {
            return _dbSet;
        }
    }
}
