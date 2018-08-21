using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Models
{
    public class DnsRecordUpdateDto
    {
        public List<DNSRecord> Request { get; set; }
        public DnsRecordUpdateDto()
        {
            Request = new List<DNSRecord>();
        }
    }
}
