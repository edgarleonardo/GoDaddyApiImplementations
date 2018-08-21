﻿using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CertificateAddress
    {
        public string address1 { get; set; }
        public string postalCode { get; set; }
        [QueryStringToUpperAttribute]
        public string country { get; set; }
        public string address2 { get; set; }
        public string state { get; set; }
        public string city { get; set; }
    }
}
