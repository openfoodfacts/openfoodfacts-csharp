using OpenFoodFactsCSharp.Models;
using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.Contexts;

[JsonSerializable(typeof(ProductResponse))]
[JsonSerializable(typeof(Product))]
[JsonSerializable(typeof(SearchResult))]
public partial class ProductResponseContext : JsonSerializerContext {}