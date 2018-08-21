using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudAddressListResponse
    {
        public List<CloudIpAddressResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
