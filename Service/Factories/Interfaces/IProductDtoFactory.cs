using Domain;
using Service.Dto;

namespace Service.Factories.Interfaces
{
    public interface IProductDtoFactory
    {
        ProductDto PrepareProductToProductDto(Product product);
    }
}