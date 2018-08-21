using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Models
{
    public class DomainPurchaseDto
    {        
        public DomainPurchase Request { get; set; }
        public string XShopperId { get; set; }
        public DomainPurchaseDto()
        {
            Request = new DomainPurchase();
        }
    }
}
