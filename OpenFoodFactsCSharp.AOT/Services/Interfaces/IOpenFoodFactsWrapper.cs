
using OpenFoodFactsCSharp.AOT.Models;
using System.Threading.Tasks;

namespace OpenFoodFactsCSharp.AOT.Services.Interfaces
{
    public interface IOpenFoodFactsWrapper
    {
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
