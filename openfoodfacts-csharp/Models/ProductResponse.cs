
using Newtonsoft.Json;
using OpenFoodFactsCSharp.model;

namespace OpenFoodFactsCSharp.model
{
    public class ProductResponse
    {
        public Product? Product { get; set; }

        public string? Code { get; set; }

        public bool? Status { get; set; }

        [JsonProperty("status_verbose")]
        public string? StatusVerbose { get; set; }
    }
}
