﻿using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudServerRetrieve
    {
        public string status { get; set; }
        public bool backupsEnabled { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
