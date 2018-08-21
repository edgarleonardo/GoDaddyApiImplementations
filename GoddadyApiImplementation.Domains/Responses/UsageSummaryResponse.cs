using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class UsageSummaryResponse
    {
        public int AddressCount { get; set; }
        public string TotalEstimatedCharge { get; set; }
        public string ServerCount { get; set; }
        public string BillingDate { get; set; }
    }
}
