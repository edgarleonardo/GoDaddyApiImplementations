﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class SubscriptionRelationsResponse
    {
        public string Parent { get; set; }
        public List<string> Children { get; set; }
    }
}
