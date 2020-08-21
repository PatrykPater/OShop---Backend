using Data.Infrastructure;
using Domain.Exceptions;
using Service.Dto;
using Service.Factories.Interfaces;
using Service.Mappers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _unitOfWork.ProductRepository.GetAll();
            return products.Select(p => ProductMapper.ToProductDto(p)).ToList();
        }

        public async Task<ProductDto> GetByID(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetByID(id);

            if (product == null)
                throw new ProductNotFound();

            return ProductMapper.ToProductDto(product);
        }

        public async Task<ProductDto> Add(ProductDto productDto)
        {
            var product = ProductMapper.ToProduct(productDto);

            var saveResult = await _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.Save();

            var saveResultDto = ProductMapper.ToProductDto(saveResult);
            return saveResultDto;
        }

        public async Task<ProductDto> Update(ProductDto productDto, int id)
        {
            var product = await _unitOfWork.ProductRepository.GetByID(id);
            product.ToProduct(productDto);

            var saveResult = await _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.Save();

            var saveResultDto = ProductMapper.ToProductDto(saveResult);
            return saveResultDto;
        }

        public async Task Delete(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetByID(id);
            _unitOfWork.ProductRepository.Delete(product);
            await _unitOfWork.Save();
        }
    }
}
