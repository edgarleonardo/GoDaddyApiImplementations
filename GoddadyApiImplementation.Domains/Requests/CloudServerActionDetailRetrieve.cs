using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudServerActionDetailRetrieve
    {
        public string serverId { get; set; }
        public string serverActionId { get; set; }
    }
}
