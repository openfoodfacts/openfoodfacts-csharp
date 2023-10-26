
using OpenFoodFactsCSharp.model;
using System.Threading.Tasks;

namespace OpenFoodFactsCSharp.services.interfaces
{
    public interface IOpenFoodFactsWrapper
    {
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
