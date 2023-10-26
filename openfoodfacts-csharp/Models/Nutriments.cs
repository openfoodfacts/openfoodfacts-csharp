
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.model
{
    public class Nutriments
    {
        [JsonPropertyName("salt")]
        public float? Salt { get; set; }

        [JsonPropertyName("salt_serving")]
        public float? SaltServing { get; set; }

        [JsonPropertyName("salt_100g")]
        public float? Salt100g { get; set; }

        [JsonPropertyName("salt_unit")]
        public string? SaltUnit { get; set; }

        [JsonPropertyName("fat")]
        public float? Fat { get; set; }

        [JsonPropertyName("fat_serving")]
        public float? FatServing { get; set; }

        [JsonPropertyName("fat_100g")]
        public float? Fat100g { get; set; }

        [JsonPropertyName("fat_unit")]
        public string? FatUnit { get; set; }

        [JsonPropertyName("saturated-fat")]
        public float? SaturatedFat { get; set; }

        [JsonPropertyName("saturated-fat_serving")]
        public float? SaturatedFatServing { get; set; }

        [JsonPropertyName("saturated-fat_100g")]
        public float? SaturatedFat100g { get; set; }

        [JsonPropertyName("saturated-fat_unit")]
        public string? SaturatedFatUnit { get; set; }

        [JsonPropertyName("sugars")]
        public float? Sugars { get; set; }

        [JsonPropertyName("sugars_serving")]
        public float? SugarsServing { get; set; }

        [JsonPropertyName("sugars_100g")]
        public float? Sugars100g { get; set; }

        [JsonPropertyName("sugars_unit")]
        public string? SugarsUnit { get; set; }

        [JsonPropertyName("carbohydrates")]
        public float? Carbohydrates { get; set; }

        [JsonPropertyName("carbohydrates_serving")]
        public float? CarbohydratesServing { get; set; }

        [JsonPropertyName("carbohydrates_100g")]
        public float? Carbohydrates100g { get; set; }

        [JsonPropertyName("carbohydrates_unit")]
        public string? CarbohydratesUnit { get; set; }

        [JsonPropertyName("energy-kcal_100g")]
        public float? EnergyKcal100g { get; set; }

        [JsonPropertyName("energy-kcal_serving")]
        public float? EnergyKcalServing { get; set; }

        [JsonPropertyName("energy-kcal_unit")]
        public string? EnergyKcalUnit { get; set; }

        [JsonPropertyName("proteins")]
        public float? Proteins { get; set; }

        [JsonPropertyName("proteins_serving")]
        public float? ProteinsServing { get; set; }

        [JsonPropertyName("proteins_100g")]
        public float? Proteins100g { get; set; }

        [JsonPropertyName("proteins_unit")]
        public string? ProteinsUnit { get; set; }

        // ... and other nutrients ...

        // To capture any unexpected properties
        public Dictionary<string, object> Other { get; set; } = new Dictionary<string, object>();
    }
}
