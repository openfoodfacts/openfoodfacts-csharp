
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenFoodFactsCSharp.Models
{
    public class Ingredient
    {
        [JsonProperty("from_palm_oil")]
        public string FromPalmOil { get; set; }
        
        public string Id { get; set; }
        
        public string Origin { get; set; }
        
        public string Percent { get; set; }
        
        public int? Rank { get; set; }
        
        public string Text { get; set; }
        
        public string Vegan { get; set; }
        
        public string Vegetarian { get; set; }
    }
}
