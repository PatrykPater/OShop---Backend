using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
    }
}