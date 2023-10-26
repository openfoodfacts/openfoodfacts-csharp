
using System;
using System.Net.Http;
using pl.coderion.model;
using pl.coderion.client;
using pl.coderion.service;
using System.Threading.Tasks;

namespace pl.coderion.service.impl
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
