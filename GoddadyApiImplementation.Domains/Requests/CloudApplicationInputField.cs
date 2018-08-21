using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudApplicationInputField
    {
        public string type { get; set; }
        public string name { get; set; }
        [JsonProperty("default")]
        public string defaultVal { get; set; }
        public List<CloudApplicationInputFieldValidator> validators { get; set; }

    }
}
