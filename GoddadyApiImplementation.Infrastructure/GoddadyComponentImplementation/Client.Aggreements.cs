﻿using GoddadyApiImplementation.Domains.Responses;
using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GoddadyApiImplementation.Infrastructure.Helper;

namespace GoddadyApiImplementation.Infrastructure
{
    public partial class Client
    {

        /// <summary>
        /// Retrieve Legal Agreements for provided agreements keys
        /// </summary>
        /// <param name="request"></param>
        /// <param name="XPrivateLabelId"></param>
        /// <param name="XMarketId"></param>
        /// <returns></returns>
        public async Task<List<LegalAgreementResponse>> RetrieveAggreements(AggreementRetrieve request, string XPrivateLabelId = null, string XMarketId = null)
        {
            var client = GetBaseHttpClient();

            if (XPrivateLabelId != null)
                client.DefaultRequestHeaders.Add("X-Private-Label-Id", XPrivateLabelId);
            if (XMarketId != null)
                client.DefaultRequestHeaders.Add("X-Market-Id", XMarketId);
            var response = await client.GetAsync($"aggreements{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<List<LegalAgreementResponse>>();
        }

    }
}
