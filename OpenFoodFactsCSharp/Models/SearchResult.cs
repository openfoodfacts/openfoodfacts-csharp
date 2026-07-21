using System.Text.Json.Serialization;
using static System.StringComparison;

namespace OpenFoodFactsCSharp.Models;

public class SearchResult
{   
    [JsonPropertyName("id")]
    public string RawIDValue { get; set; }
    
    [JsonPropertyName("lc_name")]
    public string RawLCValue { get; set; }

    [JsonPropertyName("name")]
    public string RawNameValue { get; set; }

    [JsonIgnore]
    public bool FoundID => RawIDValue?.Equals("product_found", InvariantCulture) ?? false;
    
    [JsonIgnore]
    public bool FoundLC => RawLCValue?.Equals("Product found", InvariantCulture) ?? false;
    
    [JsonIgnore]
    public bool FoundName => RawNameValue?.Equals("Product found", InvariantCulture) ?? false;
}