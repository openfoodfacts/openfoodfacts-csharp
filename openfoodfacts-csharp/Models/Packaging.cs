// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenFoodFactsCSharp.Models
{
    public class Packaging
    {
        [JsonProperty("non_recyclable_and_non_biodegradable_materials")]
        public string NonRecyclableAndNonBiodegradableMaterials {get;set;}
        
        [JsonProperty("packagings")]
        public Packagings[] Packagings { get;set;}
    }

    public class Packagings
    {
        [JsonProperty("ecoscore_material_score")]
        public decimal EcoscoreMaterialScore {get;set;}
        [JsonProperty("ecoscore_shape_ratio")]
        public decimal EcoscoreShapeRatio {get;set;}
        [JsonProperty("material")]
        public string Material {get;set;}
        [JsonProperty("material_shape")]
        public string MaterialShape {get;set;}
        [JsonProperty("non_recyclable_and_non_biodegradable")]
        public string NonRecyclableAndNonBiodegradable {get;set; }
        [JsonProperty("shape")]
        public string Shape { get; set; }

    }
}
