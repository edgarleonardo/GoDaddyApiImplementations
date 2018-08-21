using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class JurisdictionOfIncorporationResponse
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
    }
}
