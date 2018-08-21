using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudZoneListResponse
    {
        public List<CloudZoneResponse> Resulsts { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
