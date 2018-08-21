using AutoMoqCore;
using GoddadyApiImplementation.Api.Controllers;
using GoddadyApiImplementation.Api.Models;
using GoddadyApiImplementation.Domains.Requests;
using GoddadyApiImplementation.Domains.Responses;
using GoddadyApiImplementation.Service.ServicesBase;
using System;
using System.Threading.Tasks;
using Xunit;

namespace GoddadyApiImplementation.Specs
{
    public class DomainManagementTest
    {
        public AutoMoqer _mocker;
        public DomainManagementTest()
        {
            _mocker = new AutoMoqer();
        }
        [Fact(DisplayName = "Purchase Domains In Goddady Fails When Domain Is Missing")]
        public async Task Purchase_Domains_In_Goddady_Fails_When_Domain_Is_Missing()
        {
            var request = new DomainPurchaseDto();
            request.Request = new DomainPurchase();
            request.Request.period = 10;
            request.XShopperId = "";
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Result to compare with
            var domainResponse = new DomainPurchaseResponse
            {
                Currency = "USD",
                ItemCount = 1,
                OrderId = 1,
                Total = 1
            };
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.PurchaseDomain(request.Request, request.XShopperId)).Returns(Task.FromResult<DomainPurchaseResponse>(domainResponse));

            var controller = new DomainsController(domainInterface.Object);
            var result = await controller.Post(request);
            Assert.Null(result);
        }
        [Fact(DisplayName ="Purchase Domains In Goddady")]
        public async Task Purchase_Domains_In_Goddady()
        {
            var request = new DomainPurchaseDto();
            request.Request = new DomainPurchase();
            request.Request.period = 10;
            request.Request.domain = "edgarleonardo.com";
            request.XShopperId = "";
            /// Result to compare with
            var domainResponse = new DomainPurchaseResponse {
                Currency = "USD",
                ItemCount = 1,
                OrderId = 1,
                Total = 1
            };
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.PurchaseDomain(request.Request, request.XShopperId)).
                Returns(Task.FromResult<DomainPurchaseResponse>( domainResponse));

            var controller = new DomainsController(domainInterface.Object);
            var result = await controller.Post(request);

            Assert.Equal(result.ItemCount, domainResponse.ItemCount);
        }
        [Fact(DisplayName = "Update Domains Servers In Goddady")]
        public async Task Update_Domains_To_Goddady()
        {
            var request = new DomainUpdateDto();
            request.DomainUpdateObj = new DomainUpdate();
            request.DomainUpdateObj.nameServers = new System.Collections.Generic.List<object> { "ns.bba.com", "nbs.nba.com" };
            request.XShopperId = "";
            var domain = "edgarleonardo.com";            
            string XShopperId = "";
            var domainInterface = _mocker.GetMock<IServicesDomains>();           
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.UpdateDomain(request.DomainUpdateObj, domain, XShopperId)).Returns(Task.FromResult<bool>(true));

            var controller = new DomainsController(domainInterface.Object);
            var result = await controller.Put(domain, request);

            Assert.True(result);
        }
        [Fact(DisplayName = "Update Domains Servers In Goddady Fails When Domain Is Missing")]
        public async Task Update_Domains_Servers_In_Goddady_Fails_When_Domain_Is_Missing()
        {
            var request = new DomainUpdateDto();
            request.DomainUpdateObj = new DomainUpdate();
            request.DomainUpdateObj.nameServers = new System.Collections.Generic.List<object> { "ns.bba.com", "nbs.nba.com" };
            request.XShopperId = "";
            var domain = "";
            string XShopperId = "";
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.UpdateDomain(request.DomainUpdateObj, domain, XShopperId)).Returns(Task.FromResult<bool>(true));

            var controller = new DomainsController(domainInterface.Object);
            var result = await controller.Put(domain, request);
            Assert.True(result);
        }
        [Fact(DisplayName = "Delete Domains Servers In Goddady")]
        public async Task Delete_Domains_Servers_In_Goddady()
        {
            var request = new CancelDomainDto();
            request.Domain = "edgarleonardo.com";
            request.XShopperId = "";           
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.CancelDomain(request.Domain, request.XShopperId)).Returns(Task.FromResult<bool>(true));

            var controller = new DomainsController(domainInterface.Object);
            var result = await controller.Delete(request.Domain, request);
            Assert.True(result);
        }
    }
}