﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace CaptainPlanet.Models
{
    public class Tag
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("confidence")]
        public double Confidence;
    }
}