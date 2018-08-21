using GoddadyApiImplementation.Domains.Responses;
using GoddadyApiImplementation.Domains.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GoddadyApiImplementation.Infrastructure.Helper;
using GoddadyApiImplementation.Infrastructure.Base;
using GoddadyApiImplementation.Service.ServicesBase;

namespace GoddadyApiImplementation.Infrastructure
{
    public partial class Client : IServicesDomains
    {
        private string _accessKey { get; set; }
        private string _secretKey { get; set; }
        private string _rootPath { get; set; } = "https://api.ote-godaddy.com/api/v1/";
        /// <summary>
        /// Client for calling API
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="rootPath"></param>
        public Client(string accessKey, string secretKey, string rootPath = null)
        {
            _accessKey = accessKey;
            _secretKey = secretKey;
            _rootPath = rootPath ?? _rootPath;
        }

        private HttpClient GetBaseHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_rootPath);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = GetAuthenticationHeader();
            return client;
        }

        private AuthenticationHeaderValue GetAuthenticationHeader()
        {
            return new AuthenticationHeaderValue("sso-key", $"{_accessKey}:{_secretKey}");
        }

        private async Task CheckResponseMessageIsValid(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;
            throw new GodaddyException(response.StatusCode, await response.Content.ReadAsAsync<ErrorResponse>(), "");
        }

        private bool CheckRequestValid(object Model)
        {
            var results = new List<ValidationResult>();
            var isValid = ModelValidator.IsValid(Model, out results);
            if (isValid)
                return isValid;
            else
                throw new Exception(string.Join("\n", results.Select(c => c.ErrorMessage)));
        }

    }
}
