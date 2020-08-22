using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> Add(ShoppingCart entity);
        Task<ShoppingCart> GetByID(int id);
        Task<List<ShoppingCart>> GetAll();
        void Delete(ShoppingCart entity);
        void DeleteRange(List<ShoppingCart> entities);
        ShoppingCart Update(ShoppingCart entity);
        IQueryable<ShoppingCart> Table();
    }
}
