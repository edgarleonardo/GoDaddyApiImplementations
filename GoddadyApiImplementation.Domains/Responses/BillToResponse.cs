﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class BillToResponse
    {
        public string TaxId { get; set; }
        public ContactResponse Contact { get; set; }
    }
}
