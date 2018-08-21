using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class DomainAvailableBulk
    {
        public List<string> domains { get; set; }
        public string checkType { get; set; }
    }
}
