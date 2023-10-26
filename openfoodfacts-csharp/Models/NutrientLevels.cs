
using System.Text.Json.Serialization;

namespace pl.coderion.model
{
    public class NutrientLevels
    {
        public string? Fat { get; set; }

        public string? Salt { get; set; }

        [JsonPropertyName("saturated-fat")]
        public string? SaturatedFat { get; set; }

        public string? Sugars { get; set; }
    }
}
