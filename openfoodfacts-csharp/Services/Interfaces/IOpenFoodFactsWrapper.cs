
using OpenFoodFactsCSharp.model;
using System.Threading.Tasks;

namespace OpenFoodFactsCSharp.service
{
    public interface IOpenFoodFactsWrapper
    {
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
