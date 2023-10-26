
using System;
using System.Net.Http;
using OpenFoodFactsCSharp.model;
using OpenFoodFactsCSharp.client;
using OpenFoodFactsCSharp.services;
using System.Threading.Tasks;
using OpenFoodFactsCSharp.services.interfaces;

namespace OpenFoodFactsCSharp.services
{
    public class OpenFoodFactsWrapperImpl : IOpenFoodFactsWrapper
    {
        private readonly OpenFoodFactsApiLowLevelClient _client;

        // Dependency is injected via the constructor
        public OpenFoodFactsWrapperImpl(OpenFoodFactsApiLowLevelClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
            return await _client.FetchProductByCodeAsync(code);
        }
    }
}
