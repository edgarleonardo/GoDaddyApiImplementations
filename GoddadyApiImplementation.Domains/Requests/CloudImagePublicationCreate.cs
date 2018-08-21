﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudImagePublicationCreate
    {
        public List<string> dataCenterIds { get; set; }
        public string applicationId { get; set; }
    }
}
