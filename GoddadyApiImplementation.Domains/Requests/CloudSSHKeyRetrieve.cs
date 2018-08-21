using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudSSHKeyRetrieve
    {
        public string name { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
