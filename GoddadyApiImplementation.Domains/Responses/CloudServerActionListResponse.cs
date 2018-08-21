using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudServerActionListResponse
    {
        public List<CloudServerActionResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
