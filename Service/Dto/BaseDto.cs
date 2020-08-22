using Newtonsoft.Json;

namespace Service.Dto
{
    public abstract class BaseDto
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
    }
}
