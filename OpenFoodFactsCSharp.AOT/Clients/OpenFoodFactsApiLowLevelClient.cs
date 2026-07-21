using OpenFoodFactsCSharp.AOT.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using static OpenFoodFactsCSharp.AOT.Contexts.ProductResponseContext;

namespace OpenFoodFactsCSharp.AOT.Clients
{
    public class OpenFoodFactsApiLowLevelClient(HttpClient httpClient)
    {
        private const string ApiUrl = "https://world.openfoodfacts.org/api/v3";
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        private void AddUserAgentToRequest()
        {
            _httpClient.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (X11; Linux x86_64; rv:152.0) Gecko/20100101 Firefox/152.0");
        }
        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
            AddUserAgentToRequest();
            
            string requestUri = $"{ApiUrl}/product/{code}.json";
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
            
            if (!response.IsSuccessStatusCode)
            {
                // Handle error or throw an exception
                throw new HttpRequestException($"Failed to fetch product by code: {code}");
            }

            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            ProductResponse content = await response.Content.ReadFromJsonAsync(Default.ProductResponse, cts.Token);
            
            return content;
        }
    }
}
