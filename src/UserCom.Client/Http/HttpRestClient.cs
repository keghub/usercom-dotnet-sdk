using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UserCom.Http
{
    public class HttpRestClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerSettings _serializerSettings;

        public HttpRestClient(HttpClient client, JsonSerializerSettings serializerSettings)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _serializerSettings = serializerSettings ?? throw new ArgumentNullException(nameof(serializerSettings));
        }
        
        public async Task<TResult> SendAsync<TContent, TResult>(HttpMethod method, string url, TContent? content, IQueryString? query = null) where TContent : class
        {
            using var request = new HttpRequestMessage(method, ComposeUrl(url, query));

            request.Content = GetRequestContent(content);
            
            using var response = await _client.SendAsync(request).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                await HandleNonSuccess(response);
            }

            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<TResult>(responseString, _serializerSettings)!;
        }
        
        public Task<TResult> SendAsync<TResult>(HttpMethod method, string url, IQueryString? query = null)
        {
            return SendAsync<object, TResult>(method, url, null, query);
        }

        public async Task SendAsync<TContent>(HttpMethod method, string url, TContent? content, IQueryString? query = null) where TContent: class
        {
            using var request = new HttpRequestMessage(method, ComposeUrl(url, query));
            
            request.Content = GetRequestContent(content);

            using var response = await _client.SendAsync(request).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                await HandleNonSuccess(response);
            }
        }

        public Task SendAsync(HttpMethod method, string url, IQueryString? query = null)
        {
            return SendAsync<object>(method, url, null, query);
        }

        #region Helpers
        
        private static string ComposeUrl(string url, IQueryString? query) => query is { HasItems: true } ? $"{url}?{query.Query}" : url;

        private HttpContent? GetRequestContent<TContent>(TContent? content) where TContent : class
        {
            if (content == null)
            {
                return null;
            }

            var json = JsonConvert.SerializeObject(content, _serializerSettings);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            return httpContent;
        }

        private static async Task HandleNonSuccess(HttpResponseMessage response)
        {
            try
            {
                var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                throw new UserComClientException(response.RequestMessage.Method, response.RequestMessage.RequestUri.PathAndQuery, response.StatusCode, response.ReasonPhrase, responseContent);
            }
            catch (Exception ex)
            {
                throw new UserComClientException(response.RequestMessage.Method, response.RequestMessage.RequestUri.PathAndQuery, response.StatusCode, response.ReasonPhrase, ex.Message, ex);
            }
        }

        #endregion
    }
}