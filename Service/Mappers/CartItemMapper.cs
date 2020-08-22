using Domain;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Mappers
{
    public static class CartItemMapper
    {
        public static CartItem ToCartItem(CartItemDto cartItemDto)
        {
            return new CartItem
            {
                ProductId = cartItemDto.ProductId,
                Quantity = cartItemDto.Quantity,
                ShoppingCartId = cartItemDto.ShoppingCartId
            };
        }
        public static CartItemDto ToCartItemDto(CartItem cartItem)
        {
            return new CartItemDto
            {
                Id = cartItem.Id,
                ProductId = cartItem.ProductId,
                Quantity = cartItem.Quantity,
                ShoppingCartId = cartItem.ShoppingCartId
            };
        }

        public static void ToCartItem(this CartItem cartItem, CartItemDto cartItemDto)
        {
            cartItem.ProductId = cartItemDto.ProductId;
            cartItem.Quantity = cartItemDto.Quantity;
            cartItem.ShoppingCartId = cartItemDto.ShoppingCartId;
        }

        public static void FillInCartItemDtoDetails(this CartItemDto cartItemDto, ProductDto product)
        {
            cartItemDto.Name = product.Name;
            cartItemDto.Price = product.Price;
            cartItemDto.ImageUrl = product.ImageUrl;
            cartItemDto.ItemTotal = product.Price * cartItemDto.Quantity;
        }
    }
}
