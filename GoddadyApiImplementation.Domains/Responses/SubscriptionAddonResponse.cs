using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class SubscriptionAddonResponse
    {
        public int Pfid { get; set; }
        public string Commitment { get; set; }
        public int Quantity { get; set; }
    }
}
