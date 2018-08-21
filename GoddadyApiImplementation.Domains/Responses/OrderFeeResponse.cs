using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class OrderFeeResponse
    {
        public decimal Total { get; set; }
        public int Icann { get; set; }
    }
}
