using Service.Dto;
using System.Threading.Tasks;

namespace Service.Factories.Interfaces
{
    public interface ICartItemFactory
    {
        Task<CartItemDto> PrepareCartItemDto(CartItemDto cartItemDto);
    }
}