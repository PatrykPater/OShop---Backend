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
                CartItems = shoppingCartDto.CartItems.Any() ? 
                            shoppingCartDto.CartItems.Select(itemDto => CartItemMapper.ToCartItem(itemDto)) :
                            new List<CartItem>(),
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
            shoppingCart.CartItems = UpdateCartItems(shoppingCart.CartItems, shoppingCartDto.CartItems);
        }

        private static List<CartItem> UpdateCartItems(IEnumerable<CartItem> cartItems, IEnumerable<CartItemDto> cartItemDtos)
        {
            var result = new List<CartItem>();
            
            if (!cartItemDtos.Any())
                return result;
            
            foreach (var cartItemDto in cartItemDtos)
            {
                var cartItem = cartItems.FirstOrDefault(c => c.ProductId == cartItemDto.ProductId);

                if (cartItem == null)
                {
                    cartItem = CartItemMapper.ToCartItem(cartItemDto);
                }
                else
                {
                    cartItem.ToCartItem(cartItemDto);
                }

                result.Add(cartItem);
            }

            return result;
        }
    }
}
