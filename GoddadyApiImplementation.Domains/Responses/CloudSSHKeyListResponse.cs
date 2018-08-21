using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudSSHKeyListResponse
    {
        public List<CloudSSHKeyResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
