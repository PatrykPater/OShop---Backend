using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Dto
{
    public class CartItemDto : BaseDto
    {
        public decimal Quantity { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
    }
}
