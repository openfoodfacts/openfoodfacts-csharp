using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.Models;
public class ProductResponse
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("errors")]
    public string[] Errors { get; set; }

    [JsonPropertyName("product")]
    public Product Product { get; set; }
    
    [JsonPropertyName("result")]
    public SearchResult Result { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("warnings")]
    public string[] Warnings { get; set; }
    
    // [JsonPropertyName("status_verbose")]
    // public string StatusVerbose { get; set; }
}