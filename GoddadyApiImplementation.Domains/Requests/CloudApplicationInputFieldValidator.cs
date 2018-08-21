using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudApplicationInputFieldValidator
    {
        public string type { get; set; }
        public string regex { get; set; }

    }
}
