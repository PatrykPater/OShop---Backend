using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Dto
{
    public class ShoppingCartDto : BaseDto
    {
        public ShoppingCartDto()
        {
            CartItems = new List<CartItemDto>();
        }

        [JsonProperty(PropertyName = "userId")]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "cartItems")]
        public IEnumerable<CartItemDto> CartItems { get; set; }
    }
}
