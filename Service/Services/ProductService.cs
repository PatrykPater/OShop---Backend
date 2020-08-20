using Data.Infrastructure;
using Service.Dto;
using Service.Factories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductDtoFactory _productDtoFactory;

        public ProductService(IUnitOfWork unitOfWork,
            IProductDtoFactory productDtoFactory)
        {
            _unitOfWork = unitOfWork;
            _productDtoFactory = productDtoFactory;
        }
        public List<ProductDto> GetAll()
        {
            var products = _unitOfWork.DB.Products.ToList();
            return products.Select(p => _productDtoFactory.PrepareProductToProductDto(p)).ToList();
        }
    }
}
