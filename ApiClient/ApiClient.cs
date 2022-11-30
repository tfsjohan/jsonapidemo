using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
    using System.Net.Http;
    
    public class ApiClient
    {
        private static HttpClient _sharedClient;

        public ApiClient(string baseUrl, string authHeader = null)
        {
            _sharedClient = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
            

            if (!string.IsNullOrEmpty(authHeader))
            {
                _sharedClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(authHeader);
            }
        }

        public async Task<T> GetJson<T>(string path)
        {
            return await _sharedClient.GetFromJsonAsync<T>(path, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
    }
}