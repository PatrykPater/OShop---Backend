using Service.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAll();
    }
}