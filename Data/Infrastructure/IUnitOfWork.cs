using Data.Repositories;
using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        IShoppingCartRepository ShoppingCartRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        Task Save();
    }
}