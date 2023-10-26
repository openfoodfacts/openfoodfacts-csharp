
using pl.coderion.model;
using System.Threading.Tasks;

namespace pl.coderion.service
{
    public interface IOpenFoodFactsWrapper
    {
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
