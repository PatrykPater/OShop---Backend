using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Dto
{
    public class CategoryDto : BaseDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
