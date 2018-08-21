﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class JsonPropertyResponse
    {
        public string Type { get; set; }
        [JsonProperty("$ref")]
        public string RefVal { get; set; }
        public JsonDataTypeResponse Items  { get; set; }
        public bool Required { get; set; }
        public int? MaxItems { get; set; }
        public int? MinItems { get; set; }
        public string DefaultValue { get; set; }
        public string Format { get; set; }
        public string Pattern { get; set; }
        public int? Maximum { get; set; }
        public int? Minimum { get; set; }
    }
}
