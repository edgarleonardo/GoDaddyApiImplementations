using GoddadyApiImplementation.Api.Models;
using GoddadyApiImplementation.Service.ServicesBase;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DnsRecordController : ControllerBase
    {
        private IServicesDomains _servicesDomain;
        public DnsRecordController(IServicesDomains servicesDomain)
        {
            _servicesDomain = servicesDomain;
        }       
        
        [HttpPost]
        public async Task<bool> Post([FromBody] DnsRecordDto obj)
        {
            if (obj == null || obj.Request == null || string.IsNullOrEmpty(obj.Domain) || obj.Request.Count <= 0)
            {
                return false;
            }
            var result = await _servicesDomain.AddDNSRecordsToDomain(obj.Request, obj.Domain);
            return result;
        }
        
        [HttpPut("{domain}")]
        public async Task <bool> Put(string domain,[FromBody] DnsRecordDto obj)
        {
            obj.Domain = domain;
            if (obj == null || obj.Request == null || string.IsNullOrEmpty(obj.Domain) || obj.Request.Count <= 0)
            {
                return false;
            }
            var result = await _servicesDomain.ReplaceDNSRecord(obj.Request, domain);
            return result;
        }

    }
}
