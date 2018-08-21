using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class DomainAvailableBulkMixedResponse
    {
        public List<DomainAvailableResponse> Domains { get; set; }
        public List<DomainAvailableErrorResponse> Errors { get; set; }
    }
}
