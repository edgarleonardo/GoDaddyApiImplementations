﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class DomainAgreements
    {
        public List<string> tlds { get; set; }
        public bool privacy { get; set; }
        public bool forTransfer { get; set; }
    }
}
