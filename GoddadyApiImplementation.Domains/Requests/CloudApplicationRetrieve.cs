﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudApplicationRetrieve
    {
        public string category { get; set; }
        public string imageId { get; set; }
        public string status { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }

    }
}