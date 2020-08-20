using Service.Dto;
using System.Collections.Generic;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
    }
}