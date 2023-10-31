
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Models;

namespace OpenFoodFactsCSharp.Clients
{
    public class OpenFoodFactsApiLowLevelClient
    {
        private const string ApiUrl = "https://world.openfoodfacts.org/api/v0";
        private readonly HttpClient _httpClient;

        public OpenFoodFactsApiLowLevelClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
            var requestUri = $"{ApiUrl}/product/{code}.json";
            var response = await _httpClient.GetAsync(requestUri);
            
            if (!response.IsSuccessStatusCode)
            {
                // Handle error or throw an exception
                throw new HttpRequestException($"Failed to fetch product by code: {code}");
            }


            var content = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductResponse>(content);

            return product;
        }
    }
}
