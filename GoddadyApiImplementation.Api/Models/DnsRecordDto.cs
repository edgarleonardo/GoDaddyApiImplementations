using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Models
{
    public class DnsRecordDto
    {
        public List<DNSRecord> Request { get; set; }
        public string Domain { get; set; }
        public DnsRecordDto()
        {
            Request = new List<DNSRecord>();
        }
    }
}