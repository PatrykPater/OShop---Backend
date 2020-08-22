using Service.Dto;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Service.Mappers;
using System.Threading.Tasks;
using Service.Factories.Interfaces;

namespace Service.Factories
{
    public class CartItemFactory : ICartItemFactory
    {
        private readonly IProductService _productService;

        public CartItemFactory(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<CartItemDto> PrepareCartItemDto(CartItemDto cartItemDto)
        {
            var product = await _productService.GetByID(cartItemDto.ProductId);
            cartItemDto.FillInCartItemDtoDetails(product);

            return cartItemDto;
        }
    }
}
