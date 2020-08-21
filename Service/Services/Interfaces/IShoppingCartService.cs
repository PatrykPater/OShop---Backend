using Service.Dto;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IShoppingCartService
    {
        Task<ShoppingCartDto> Add(ShoppingCartDto shoppingCartDto);
        Task<ShoppingCartDto> GetByID(int id);
    }
}