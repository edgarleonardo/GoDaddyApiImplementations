using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class SubscriptionRetrieve
    {
        public List<string> productGroupKeys { get; set; }
        public List<string> includes { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string sort { get; set; }
    }
}
