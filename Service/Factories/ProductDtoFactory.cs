using Domain;
using Service.Dto;
using Service.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Factories
{
    public class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto PrepareProductToProductDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrt = product.ImageUrl,
                Price = product.Price,
                CategoryId = product.CategoryId ?? 0
            };
        }
    }
}
