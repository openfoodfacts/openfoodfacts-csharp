
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenFoodFactsCSharp.Models
{
    public class NutrientLevels
    {
        public string Fat { get; set; }
        
        public string Salt { get; set; }
        
        [JsonProperty("saturated-fat")]
        public string SaturatedFat { get; set; }
        
        public string Sugars { get; set; }
    }
}
