﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudServerVolumeRetrieve
    {
        public string serverId { get; set; }
        public string volumeId { get; set; }
    }
}
