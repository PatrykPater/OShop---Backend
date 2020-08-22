using Data.Repositories.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> Add(Product entity);
        Task<Product> GetByID(int id);
        Task<List<Product>> GetAll();
        void Delete(Product entity);
        void DeleteRange(List<Product> entities);
        Product Update(Product entity);
        IQueryable<Product> Table();
    }
}