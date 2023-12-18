// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Newtonsoft.Json;

namespace OpenFoodFactsCSharp.Models
{
    public class Adjustments
    {
        [JsonProperty("packaging")]
        public Packaging Packaging { get; set; }
    }
}
