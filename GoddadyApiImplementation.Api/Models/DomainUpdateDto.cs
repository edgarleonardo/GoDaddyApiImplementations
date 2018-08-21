using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Models
{
    public class DomainUpdateDto
    {
        public DomainUpdate DomainUpdateObj { get; set; }
        public string XShopperId { get; set; }
        public DomainUpdateDto()
        {
            DomainUpdateObj = new DomainUpdate();
        }
    }
}
