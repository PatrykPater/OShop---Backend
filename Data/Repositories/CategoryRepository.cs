using Data.Repositories.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContext _dBContext;
        private readonly DbSet<Category> _dbSet;

        public CategoryRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = _dBContext.Set<Category>();
        }

        public virtual async Task<List<Category>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
