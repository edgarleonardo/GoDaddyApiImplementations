using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudServerVolumeListResponse
    {
        public List<CloudServerVolumeResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
