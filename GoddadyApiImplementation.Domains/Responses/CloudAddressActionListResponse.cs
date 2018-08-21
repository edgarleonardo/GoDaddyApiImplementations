using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudAddressActionListResponse
    {
        public List<CloudAddressActionResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
