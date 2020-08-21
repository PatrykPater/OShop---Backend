using Domain;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Mappers
{
    public static class ShoppingCartMapper
    {
        public static ShoppingCart ToShoppingCart(ShoppingCartDto shoppingCartDto)
        {
            return new ShoppingCart
            {
                CartItems = shoppingCartDto.CartItems.Select(itemDto => CartItemMapper.ToCartItem(itemDto)),
                Created = shoppingCartDto.Created,
                UserId = shoppingCartDto.UserId
            };
        }

        public static ShoppingCartDto ToShoppingCartDto(ShoppingCart shoppingCart)
        {
            return new ShoppingCartDto
            {
                 CartItems = shoppingCart.CartItems.Select(item => CartItemMapper.ToCartItemDto(item)),
                 Created = shoppingCart.Created,
                 Id = shoppingCart.Id,
                 UserId = shoppingCart.UserId
            };
        }

        public static void ToShoppingCart(this ShoppingCart shoppingCart, ShoppingCartDto shoppingCartDto)
        {
            shoppingCart.Created = shoppingCartDto.Created;
            shoppingCart.UserId = shoppingCartDto.UserId;
        }

        private static void UpdateCartItems(List<CartItem> cartItems, List<CartItemDto> cartItemDtos)
        {
            foreach (var cartItemDto in cartItemDtos)
            {
            }
        }
    }
}
