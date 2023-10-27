
using Newtonsoft.Json;

namespace OpenFoodFactsCSharp.Models
{
    public class Source
    {
        public string[] Fields { get; set; } = { };
        
        public string Id { get; set; }
        
        public string[] Images { get; set; } = { };
        
        [JsonProperty("import_t")]
        public long? ImportT { get; set; }
        
        public string Manufacturer { get; set; }
        
        public string Name { get; set; }
        
        public string Url { get; set; }
    }
}
