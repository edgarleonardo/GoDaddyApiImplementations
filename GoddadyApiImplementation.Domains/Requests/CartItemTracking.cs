using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CartItemTracking
    {
        public string clientIp { get; set; }
        public string itemTrackingCode { get; set; }
        public string pathway { get; set; }
        public CartAffiliate affiliate { get; set; }
    }
}
