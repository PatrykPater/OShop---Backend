using Data.Repositories.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ShoppingCartRepository : BaseRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(DBContext dBContext) : base(dBContext)
        {
        }
    }
}
