using Data.Repositories.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DBContext dBContext) : base(dBContext)
        {
        }
    }
}
