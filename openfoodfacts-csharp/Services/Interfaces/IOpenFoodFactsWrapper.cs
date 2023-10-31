
using OpenFoodFactsCSharp.Models;
using System.Threading.Tasks;

namespace OpenFoodFactsCSharp.Services.Interfaces
{
    public interface IOpenFoodFactsWrapper
    {
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
