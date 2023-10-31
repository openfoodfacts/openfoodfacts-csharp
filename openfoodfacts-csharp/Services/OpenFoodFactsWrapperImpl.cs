
using System;
using OpenFoodFactsCSharp.Models;
using OpenFoodFactsCSharp.Clients;
using System.Threading.Tasks;
using OpenFoodFactsCSharp.Services.Interfaces;

namespace OpenFoodFactsCSharp.Services
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
