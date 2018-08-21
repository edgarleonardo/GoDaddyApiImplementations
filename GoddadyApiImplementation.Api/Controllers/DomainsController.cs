using GoddadyApiImplementation.Api.Models;
using GoddadyApiImplementation.Domains.Requests;
using GoddadyApiImplementation.Domains.Responses;
using GoddadyApiImplementation.Service.ServicesBase;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainsController : ControllerBase
    {
        private IServicesDomains _servicesDomain;
        public DomainsController(IServicesDomains servicesDomain)
        {
            _servicesDomain = servicesDomain;
        }

        [HttpPost]
        public async Task<DomainPurchaseResponse> Post([FromBody] DomainPurchaseDto obj)
        {
            if (obj == null || obj.Request == null || string.IsNullOrEmpty(obj.Request.domain) || !ModelState.IsValid)
            {
                return null;
            }
           var domainPurchaseResponse = await _servicesDomain.PurchaseDomain(obj.Request, obj.XShopperId);
            return domainPurchaseResponse;
        }
        
        [HttpPut("{domain}")]
        public async Task<bool> Put(string domain, [FromBody] DomainUpdateDto obj)
        {
            if (obj == null || obj.DomainUpdateObj == null || obj.DomainUpdateObj.nameServers == null || obj.DomainUpdateObj.nameServers.Count <= 0 )
            {
                return false;
            }
            var result = await _servicesDomain.UpdateDomain(obj.DomainUpdateObj, domain, obj.XShopperId);
            return result;
        }
        
        [HttpDelete("{url}")]
        public async Task<bool> Delete(string url, [FromBody] CancelDomainDto cancel)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            var result = await _servicesDomain.CancelDomain(url, cancel.XShopperId);
            return result;

        }
    }
}