using Service.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
        Task<ProductDto> GetByID(int id);
        Task<ProductDto> Add(ProductDto productDto);
        Task<ProductDto> Update(ProductDto productDto, int id);
        Task Delete(int id);
    }
}