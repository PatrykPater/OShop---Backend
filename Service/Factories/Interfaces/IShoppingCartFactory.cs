using Service.Dto;
using System.Threading.Tasks;

namespace Service.Factories.Interfaces
{
    public interface IShoppingCartFactory
    {
        Task<ShoppingCartDto> PrepareShoppingCartDto(ShoppingCartDto shoppingCartDto);
    }
}