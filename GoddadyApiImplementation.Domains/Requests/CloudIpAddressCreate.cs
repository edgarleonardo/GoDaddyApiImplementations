using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudIpAddressCreate
    {
        public string dataCenterId { get; set; }
        public string zoneId { get; set; }
    }
}
