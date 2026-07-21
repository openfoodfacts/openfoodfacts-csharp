using OpenFoodFactsCSharp.Clients;
using OpenFoodFactsCSharp.Models;
using OpenFoodFactsCSharp.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace OpenFoodFactsCSharp.Services
{
    // Dependency is injected via the constructor
    public class OpenFoodFactsWrapperImpl(OpenFoodFactsApiLowLevelClient client) : IOpenFoodFactsWrapper
    {
        private readonly OpenFoodFactsApiLowLevelClient _client = client ?? throw new ArgumentNullException(nameof(client));

        public async Task<ProductResponse> FetchProductByCodeAsync(string code)
        {
            return await _client.FetchProductByCodeAsync(code);
        }
    }
}
