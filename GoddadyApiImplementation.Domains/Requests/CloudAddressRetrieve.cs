﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudAddressRetrieve
    {
        public string address { get; set; }
        public string serverId { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
    }
}
