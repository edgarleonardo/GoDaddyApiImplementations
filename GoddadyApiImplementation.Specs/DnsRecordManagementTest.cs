using AutoMoqCore;
using GoddadyApiImplementation.Api.Controllers;
using GoddadyApiImplementation.Api.Models;
using GoddadyApiImplementation.Domains.Requests;
using GoddadyApiImplementation.Service.ServicesBase;
using System;
using System.Threading.Tasks;
using Xunit;

namespace GoddadyApiImplementation.Specs
{
    public class DnsRecordManagementTest
    {
        private AutoMoqer _mocker;
        public DnsRecordManagementTest()
        {
            _mocker = new AutoMoqer();
        }
        [Fact(DisplayName = "Add DNS Record To Goddady For Websites")]
        public async Task Add_DNS_Record_To_Goddady_For_Websitess()
        {
            var request = new DnsRecordDto();
            var domain = "edgarleonardo.com";
            request.Request.Add(new DNSRecord { data = "192.162.0.1", name = "@", type = "A", priority = 1, ttl = 3600 });
            request.Request.Add(new DNSRecord { data = domain, name = "@", type = "CNAME", priority = 1, ttl = 3600 });
            request.Domain = domain;
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.AddDNSRecordsToDomain(request.Request, request.Domain, null)).Returns(Task.FromResult<bool>(true));

            var controller = new DnsRecordController(domainInterface.Object);
            var result = await controller.Post(request);

            Assert.True(result);
        }
        [Fact(DisplayName = "Update DNS Record On Goddady For Websites")]
        public async Task Update_DNS_Record_On_Goddady_For_Websites()
        {
            var request = new DnsRecordDto();
            var domain = "edgarleonardo.com";
            request.Request.Add(new DNSRecord { data = "192.162.0.1", name = "@", type = "A", priority = 1, ttl = 3600 });
            request.Request.Add(new DNSRecord { data = domain, name = "@", type = "CNAME", priority = 1, ttl = 3600 });
            request.Domain = domain;
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.ReplaceDNSRecord(request.Request, request.Domain, null)).Returns(Task.FromResult<bool>(true));

            var controller = new DnsRecordController(domainInterface.Object);
            var result = await controller.Put(domain, request);

            Assert.True(result);
        }

        [Fact(DisplayName = "Fails When Adding DNS Record To Goddady For Websites")]
        public async Task Fail_When_Adding_DNS_Record_To_Goddady_For_Websitess()
        {
            var request = new DnsRecordDto();
            var domain = "";
            request.Request.Add(new DNSRecord { data = "192.162.0.1", name = "@", type = "A", priority = 1, ttl = 3600 });
            request.Request.Add(new DNSRecord { data = domain, name = "@", type = "CNAME", priority = 1, ttl = 3600 });
            request.Domain = domain;
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.AddDNSRecordsToDomain(request.Request, request.Domain, null)).Returns(Task.FromResult<bool>(true));

            var controller = new DnsRecordController(domainInterface.Object);
            var result = await controller.Post(request);

            Assert.True(!result);
        }
        [Fact(DisplayName = "Fail When Update DNS Record On Goddady For Websites")]
        public async Task Fail_When_Update_DNS_Record_On_Goddady_For_Websites()
        {
            var request = new DnsRecordDto();
            var domain = "";
            request.Request.Add(new DNSRecord { data = "192.162.0.1", name = "@", type = "A", priority = 1, ttl = 3600 });
            request.Request.Add(new DNSRecord { data = domain, name = "@", type = "CNAME", priority = 1, ttl = 3600 });
            request.Domain = domain;
            var domainInterface = _mocker.GetMock<IServicesDomains>();
            /// Setting the mocking behavior expected
            domainInterface.Setup(p => p.ReplaceDNSRecord(request.Request, request.Domain, null)).Returns(Task.FromResult<bool>(true));

            var controller = new DnsRecordController(domainInterface.Object);
            var result = await controller.Put(domain, request);
            Assert.True(!result);
        }
    }
}