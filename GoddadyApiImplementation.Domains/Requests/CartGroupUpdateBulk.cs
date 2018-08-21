using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CartGroupUpdateBulk
    {
        public string groupKey { get; set; }
        public List<CartItemUpdateBulk> items { get; set; }
    }
}
