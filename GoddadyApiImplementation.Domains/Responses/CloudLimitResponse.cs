﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CloudLimitResponse
    {
        public int Limit { get; set; }
        public int Used { get; set; }
        public int Available { get; set; }
    }
}
