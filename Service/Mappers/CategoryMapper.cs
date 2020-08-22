using Domain;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDto ToCategoryDto(Category product)
        {
            return new CategoryDto
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
