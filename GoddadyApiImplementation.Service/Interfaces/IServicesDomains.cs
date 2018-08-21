using GoddadyApiImplementation.Domains.Requests;
using GoddadyApiImplementation.Domains.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Service.ServicesBase
{
    public interface IServicesDomains
    {
        Task<bool> AddDNSRecordsToDomain(List<DNSRecord> request, string domain, string XShopperId = null);
        /// <summary>
        /// Determine whether or not the specified domains are available for purchase
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DomainAvailableBulkResultResponse> BulkCheckDomainAvailable(Domains.Requests.DomainAvailableBulk request);
        /// <summary>
        /// Cancel a purchased domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> CancelDomain(string request, string XShopperId = null);
        /// <summary>
        /// Submit a privacy cancellation request for the given domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> CancelPrivacy(PrivacyDelete request, string XShopperId = null);
        /// <summary>
        /// Determine whether or not the specified domain is available for purchase
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DomainAvailableResponse> CheckDomainAvailable(DomainAvailable request);
        /// <summary>
        /// Purchase and register the specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainPurchaseResponse> PurchaseDomain(DomainPurchase request, string XShopperId = null);
        /// <summary>
        /// Purchase and register the specified Domain without privacy (For the Tld which is not support privacy)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainPurchaseResponse> PurchaseDomainWithoutPrivacy(DomainPurchaseWithoutPrivacy request, string XShopperId = null);
        /// <summary>
        /// Purchase privacy for a specified domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainPurchaseResponse> PurchasePrivacy(PrivacyPurchase request, string domain, string XShopperId = null);
        /// <summary>
        /// Retrieve the schema to be submitted when registering a Domain for the specified TLD
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<JsonPropertyResponse> RetrieveDomainPurhcaseSchema(DomainPurchaseSchema request);
        /// <summary>
        /// Validate the request body using the Domain Purchase Schema for the specified TLD
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<bool> PurchaseDomainValidate(DomainPurchase request);
        /// <summary>
        /// Validate the request body using the Domain Purchase Schema for the specified TLD (For the Tld which is not support privacy)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<bool> PurchaseDomainValidateWithoutPrivacy(DomainPurchaseWithoutPrivacy request);
        /// <summary>
        /// Renew the specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainPurchaseResponse> RenewDomain(DomainRenew request, string domain, string XShopperId = null);
        /// <summary>
        /// Replace all DNS Records for the specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> ReplaceDNSRecord(List<DNSRecord> request, string domain, string XShopperId = null);
        /// <summary>
        /// Replace all DNS Records for the specified Domain with the specified Type
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="Type"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> ReplaceDNSRecordsWithType(List<DNSRecordCreateType> request, string domain, string Type, string XShopperId = null);
        /// <summary>
        /// Replace all DNS Records for the specified Domain with the specified Type and Name
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="Type"></param>
        /// <param name="Name"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> ReplaceDNSRecordsWithTypeAndName(List<DNSRecordCreateTypeName> request, string domain, string Type, string Name, string XShopperId = null);
        /// <summary>
        /// Retrieve the legal agreement(s) required to purchase the specified TLD and add-ons
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XMarketId"></param>
        /// <returns></returns>
        Task<List<LegalAgreementResponse>> RetrieveDomainAgreements(DomainAgreements request, string XMarketId);
        /// <summary>
        /// Retrieve a list of Domains for the specified Shopper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> RetrieveDomainList(DomainRetrieve request, string XShopperId = null);
        /// <summary>
        /// Retrieve details for the specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="Type"></param>
        /// <param name="Name"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainDetailRetrieve> RetrieveDomainDetail(DomainDetailRetrieve request, string domain, string Type, string Name, string XShopperId = null);
        /// <summary>
        /// Retrieve DNS Records for the specified Domain, optionally with the specified Type and/or Name
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="Type"></param>
        /// <param name="Name"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<List<DNSRecordResponse>> RetrieveDNSRecordsWithTypeAndName(DNSRecordRetrieve request, string domain, string Type, string Name, string XShopperId = null);
        /// <summary>
        /// Suggest alternate Domain names based on a seed Domain, a set of keywords, or the shopper's purchase history
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<List<DomainSuggestionResponse>> RetrieveSuggestDomain(DomainSuggest request);
        /// <summary>
        /// Retrieves a list of TLDs supported and enabled for sale
        /// </summary>
        /// <returns></returns>
        Task<List<TldSummaryResponse>> RetrieveTldSummary();
        /// <summary>
        /// Purchase and start or restart transfer process
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<DomainTransferIn> TransferDomain(DomainTransferIn request, string domain, string XShopperId = null);
        /// <summary>
        /// Update details for the specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> UpdateDomain(DomainUpdate request, string domain, string XShopperId = null);
        /// <summary>
        /// Update domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="domain"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> UpdateDomainContacts(DomainContacts request, string domain, string XShopperId = null);
        /// <summary>
        /// Re-send Contact E-mail Verification for specified Domain
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XShopperId"></param>
        /// <returns></returns>
        Task<bool> VerifyRegistrantEmail(VerifyRegistrantEmail request, string XShopperId = null);
    }
}