using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class TamperSignature
    {
        public string hash { get; set; }
        public string content { get; set; }
    }
}
