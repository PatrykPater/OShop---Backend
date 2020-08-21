using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Dto
{
    public class ShoppingCartDto : BaseDto
    {
        public int? UserId { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<CartItemDto> CartItems { get; set; }
    }
}
