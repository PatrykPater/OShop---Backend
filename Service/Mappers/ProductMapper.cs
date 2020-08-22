using Domain;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToProductDto (Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                CategoryId = product.CategoryId,
                CategoryName = product.Category?.Name
            };
        }

        public static Product ToProduct(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                ImageUrl = productDto.ImageUrl,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId
            };

            return product;
        }

        public static void ToProduct(this Product product, ProductDto productDto)
        {
            product.CategoryId = productDto.CategoryId;
            product.ImageUrl = productDto.ImageUrl;
            product.Name = productDto.Name;
            product.Price = product.Price;
        }
    }
}
