﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudDataCenterZoneRetrieve
    {
        public string status { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
    }
}
