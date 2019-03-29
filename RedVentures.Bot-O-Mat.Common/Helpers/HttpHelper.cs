using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Generic Wrapper for common http Get and Post requests. Logs exceptions
    /// </summary>
    public class HttpHelper : IHttpHelper
    {
        #region ctor && private
        private readonly HttpClient _httpClient;
        private HttpResponseMessage _response;
        private string _responseBody;

        public HttpHelper(Guid correlationId, IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.DefaultRequestHeaders.Add("correlationid", correlationId.ToString());
        }
        public HttpHelper(Guid correlationId, AuthenticationHeaderValue authenticationHeaderValue, IHttpClientFactory httpClientFactory) : this(correlationId, httpClientFactory) => _httpClient.DefaultRequestHeaders.Authorization = authenticationHeaderValue;
        public HttpHelper(Guid correlationId, string clientId, string secretId, IHttpClientFactory httpClientFactory) : this(correlationId, httpClientFactory)
        {
            _httpClient.DefaultRequestHeaders.Add("client_id", clientId);
            _httpClient.DefaultRequestHeaders.Add("client_secret", secretId);
        }
        #endregion
        #region public
        public async Task<ReturnType> Get<ReturnType>(string URI)
        {
            _response = await _httpClient.GetAsync(URI);
            _responseBody = await _response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ReturnType>(_responseBody);
        }

        /// <summary>
        /// <para>URI = request destination</para>
        /// <para>ReturnType = deserialized class of expected 200 response</para>
        /// <para>PostBody = class instance to set post body with</para>
        /// <para></para>
        /// </summary>
        /// <typeparam name="PostBody"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="URI"></param>
        /// <param name="httpBody"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public async Task<ReturnType> Post<PostBody, ReturnType>(string URI, PostBody httpBody, string contentType = ContentTypes.Json)
        {
            await PostRequest(URI, httpBody, contentType);
            _responseBody = await _response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ReturnType>(_responseBody);
        }

        /// <summary>
        /// can be used to requests of which we don't need or have a specific response
        /// </summary>
        /// <typeparam name="PostBody"></typeparam>
        /// <param name="URI"></param>
        /// <param name="httpBody"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> Post<PostBody>(string URI, PostBody httpBody, string contentType = ContentTypes.Json)
        {
            await PostRequest(URI, httpBody, contentType);
            return _response;
        }

        #region helpers
        private async Task PostRequest<PostBody>(string URI, PostBody httpBody, string contentType)
        {
            if (contentType == ContentTypes.Form) _response = await _httpClient.PostAsync(URI, new FormUrlEncodedContent(GenerateFormBody(httpBody)));
            else _response = await _httpClient.PostAsync(URI, new StringContent(JsonConvert.SerializeObject(httpBody), Encoding.UTF8, contentType));
            _response.EnsureSuccessStatusCode();
        }
        private static Dictionary<string, string> GenerateFormBody<PostBody>(PostBody httpBody)
        {
            var json = JsonConvert.SerializeObject(httpBody);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        } 
        #endregion
        #endregion
    }

    public static class ContentTypes
    {
        public const string Json = "application/json";
        public const string Form = "application/x-www-form-urlencoded";
        public const string Download = "application/x-msdownload";
    }

    public static class AuthenticationHeaderTypes
    {
        public const string Basic = "Basic";
        public const string Bearer = "Bearer";
    }
}
