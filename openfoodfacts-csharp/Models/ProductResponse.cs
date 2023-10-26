
using System.Text.Json.Serialization;

using pl.coderion.model;

namespace pl.coderion.model
{
    public class ProductResponse
    {
        public Product? Product { get; set; }

        public string? Code { get; set; }

        public bool? Status { get; set; }

        [JsonPropertyName("status_verbose")]
        public string? StatusVerbose { get; set; }
    }
}
