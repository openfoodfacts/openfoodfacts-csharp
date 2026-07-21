using OpenFoodFactsCSharp.AOT.Models;
using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.AOT.Contexts;

[JsonSerializable(typeof(ProductResponse))]
[JsonSerializable(typeof(Product))]
[JsonSerializable(typeof(SearchResult))]
public partial class ProductResponseContext : JsonSerializerContext {}