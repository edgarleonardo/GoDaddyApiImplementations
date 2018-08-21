using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class ShopperUpdate
    {
        public string nameFirst { get; set; }
        public string nameLast { get; set; }
        public string email { get; set; }
        public int externalId { get; set; }
        public string marketId { get; set; }
    }
}
