using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CartItemListRemove
    {
        public List<int> itemIds { get; set; }
    }
}
