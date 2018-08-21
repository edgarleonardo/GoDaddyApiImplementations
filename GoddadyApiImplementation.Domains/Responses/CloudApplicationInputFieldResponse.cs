using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudApplicationInputFieldResponse
    {
        public string type { get; set; }
        public string name { get; set; }
        [JsonProperty("default")]
        public string defaultVal { get; set; }
        public List<CloudApplicationInputFieldValidatorResponse> validators { get; set; }

    }
}
