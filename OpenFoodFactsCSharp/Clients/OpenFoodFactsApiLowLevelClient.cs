using OpenFoodFactsCSharp.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using static OpenFoodFactsCSharp.Contexts.ProductResponseContext;

namespace OpenFoodFactsCSharp.Clients
{
    public class OpenFoodFactsApiLowLevelClient(HttpClient httpClient)
    {
        private const string ApiUrl = "https://world.openfoodfacts.org/api/v3";
        private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
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
