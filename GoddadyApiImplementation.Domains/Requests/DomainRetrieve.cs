using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class DomainRetrieve
    {
        public List<string> statuses { get; set; }
        public List<string> statusGroups { get; set; }
        public int limit { get; set; }
        public string marker { get; set; }
        public List<string> includes { get; set; }
        public string modifiedDate { get; set; }
    }
}
