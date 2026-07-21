// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.AOT.Models;
public class Packaging
{
    // Changed from a string to an int to fix:
    // System.InvalidOperationException : Cannot get the value of a token type 'Number' as a string.
    [JsonPropertyName("non_recyclable_and_non_biodegradable_materials")]
    public int NonRecyclableAndNonBiodegradableMaterials { get; set; }
    
    [JsonPropertyName("packagings")]
    public Packagings[] Packagings { get;set;}
}

public class Packagings
{
    [JsonPropertyName("ecoscore_material_score")]
    public decimal EcoscoreMaterialScore {get;set;}
    [JsonPropertyName("ecoscore_shape_ratio")]
    public decimal EcoscoreShapeRatio {get;set;}
    [JsonPropertyName("material")]
    public string Material {get;set;}
    [JsonPropertyName("material_shape")]
    public string MaterialShape {get;set;}
    [JsonPropertyName("non_recyclable_and_non_biodegradable")]
    public string NonRecyclableAndNonBiodegradable {get;set; }
    [JsonPropertyName("shape")]
    public string Shape { get; set; }

}
