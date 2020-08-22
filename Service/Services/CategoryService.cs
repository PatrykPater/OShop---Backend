using Data.Infrastructure;
using Service.Dto;
using Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            var categories = await _unitOfWork.CategoryRepository.GetAll();
            return categories.Select(c => CategoryMapper.ToCategoryDto(c)).ToList();
        }
    }
}
