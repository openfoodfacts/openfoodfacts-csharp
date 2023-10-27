
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenFoodFactsCSharp.Models
{
    public class Nutriments
    {
        [JsonProperty("salt")]
        public float? Salt { get; set; }
        
        [JsonProperty("salt_serving")]
        public float? SaltServing { get; set; }
        
        [JsonProperty("salt_100g")]
        public float? Salt100g { get; set; }
        
        [JsonProperty("salt_unit")]
        public string SaltUnit { get; set; }
        
        [JsonProperty("fat")]
        public float? Fat { get; set; }
        
        [JsonProperty("fat_serving")]
        public float? FatServing { get; set; }
        
        [JsonProperty("fat_100g")]
        public float? Fat100g { get; set; }
        
        [JsonProperty("fat_unit")]
        public string FatUnit { get; set; }
        
        [JsonProperty("saturated-fat")]
        public float? SaturatedFat { get; set; }
        
        [JsonProperty("saturated-fat_serving")]
        public float? SaturatedFatServing { get; set; }
        
        [JsonProperty("saturated-fat_100g")]
        public float? SaturatedFat100g { get; set; }
        
        [JsonProperty("saturated-fat_unit")]
        public string SaturatedFatUnit { get; set; }
        
        [JsonProperty("sugars")]
        public float? Sugars { get; set; }
        
        [JsonProperty("sugars_serving")]
        public float? SugarsServing { get; set; }
        
        [JsonProperty("sugars_100g")]
        public float? Sugars100g { get; set; }
        
        [JsonProperty("sugars_unit")]
        public string SugarsUnit { get; set; }
        
        [JsonProperty("carbohydrates")]
        public float? Carbohydrates { get; set; }
        
        [JsonProperty("carbohydrates_serving")]
        public float? CarbohydratesServing { get; set; }
        
        [JsonProperty("carbohydrates_100g")]
        public float? Carbohydrates100g { get; set; }
        
        [JsonProperty("carbohydrates_unit")]
        public string CarbohydratesUnit { get; set; }
        
        [JsonProperty("energy-kcal_100g")]
        public float? EnergyKcal100g { get; set; }
        
        [JsonProperty("energy-kcal_serving")]
        public float? EnergyKcalServing { get; set; }
        
        [JsonProperty("energy-kcal_unit")]
        public string EnergyKcalUnit { get; set; }
        
        [JsonProperty("proteins")]
        public float? Proteins { get; set; }
        
        [JsonProperty("proteins_serving")]
        public float? ProteinsServing { get; set; }
        
        [JsonProperty("proteins_100g")]
        public float? Proteins100g { get; set; }
        
        [JsonProperty("proteins_unit")]
        public string ProteinsUnit { get; set; }
        
        // ... and other nutrients ...
        
        // To capture any unexpected properties
        public Dictionary<string, object> Other { get; set; } = new Dictionary<string, object>();
    }
}
