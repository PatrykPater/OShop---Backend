using Data.Repositories;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _dBContext;

        public IProductRepository ProductRepository { get; }
        public IShoppingCartRepository ShoppingCartRepository { get; }

        public UnitOfWork(DBContext dBContext)
        {
            _dBContext = dBContext;

            ProductRepository = new ProductRepository(_dBContext);
            ShoppingCartRepository = new ShoppingCartRepository(_dBContext);
        }

        public async Task Save()
        {
            await _dBContext.SaveChangesAsync();
        }
    }
}
