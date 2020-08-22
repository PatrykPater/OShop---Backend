using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Dto
{
    public class CartItemDto : BaseDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "itemTotal")]
        public decimal ItemTotal { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "shoppingCartId")]
        public int ShoppingCartId { get; set; }

        [JsonProperty(PropertyName = "productId")]
        public int ProductId { get; set; }
    }
}
