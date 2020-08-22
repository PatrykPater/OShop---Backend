using Newtonsoft.Json;

namespace Service.Dto
{
    public class ProductDto : BaseDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty(PropertyName = "categoryName")]
        public string CategoryName { get; set; }
    }
}
