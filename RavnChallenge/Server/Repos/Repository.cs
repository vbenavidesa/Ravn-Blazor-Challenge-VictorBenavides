using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RavnChallenge.Server.Helpers;
using RavnChallenge.Server.Interfaces;
using RavnChallenge.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RavnChallenge.Server.Repos
{
    public class Repository : IRepository
    {
        #region Constructor
        private readonly IConfiguration configuration;
        public Repository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        #endregion

        #region public T GetSingle<T>(string Endpoint, string Id) where T : Entity
        public T GetSingle<T>(string Endpoint, string Id) where T : Entity
        {
            string apiUrl = configuration.GetSection("Urls").GetSection("SWBase").Value;
            string url = string.Format("{0}{1}{2}", apiUrl, Endpoint, Id);
            string json = ExternalRequests.Request(url, HttpMethod.Get, null);
            T response = JsonConvert.DeserializeObject<T>(json);
            return response;
        }
        #endregion

        #region public EntityResult<T> GetAllPaginated<T>(string EntityName, string PageNumber = "1") where T : Entity
        public EntityResult<T> GetAllPaginated<T>(string EntityName, string PageNumber = "1") where T : Entity
        {
            string apiUrl = configuration.GetSection("Urls").GetSection("SWBase").Value;
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("page", PageNumber);

            string serializedParameters = "";
            if (parameters != null)
            {
                serializedParameters = "?" + Serializer.SerializeDictionary(parameters);
            }
            string url = string.Format("{0}{1}{2}", apiUrl, EntityName, serializedParameters);
            string json = ExternalRequests.Request(url, HttpMethod.Get, null);
            EntityResult<T> result = JsonConvert.DeserializeObject<EntityResult<T>>(json);

            result.NextPageNo = String.IsNullOrEmpty(result.Next) ? null : Queries.GetQueryParameters(result.Next)["page"];
            result.PreviousPageNo = String.IsNullOrEmpty(result.Previous) ? null : Queries.GetQueryParameters(result.Previous)["page"];

            return result;
        }
        #endregion
    }
}
