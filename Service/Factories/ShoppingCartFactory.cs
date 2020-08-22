using Service.Dto;
using Service.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Factories
{
    public class ShoppingCartFactory : IShoppingCartFactory
    {
        private readonly ICartItemFactory _cartItemFactory;

        public ShoppingCartFactory(ICartItemFactory cartItemFactory)
        {
            _cartItemFactory = cartItemFactory;
        }

        public async Task<ShoppingCartDto> PrepareShoppingCartDto(ShoppingCartDto shoppingCartDto)
        {
            //shoppingCartDto.CartItems = await shoppingCartDto.CartItems.Select( async item => await _cartItemFactory.PrepareCartItemDto(item));

            var itemList = shoppingCartDto.CartItems.Select(i => i);
            var detailedList = new List<CartItemDto>();

            foreach (var item in itemList)
            {
                var detailedDto = await _cartItemFactory.PrepareCartItemDto(item);
                detailedList.Add(detailedDto);
            }

            shoppingCartDto.CartItems = detailedList;

            return shoppingCartDto;
        }
    }
}
