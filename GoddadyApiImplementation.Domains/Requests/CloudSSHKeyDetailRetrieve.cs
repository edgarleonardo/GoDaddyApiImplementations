using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CloudSSHKeyDetailRetrieve
    {
        public string sshKeyId { get; set; }
    }
}
