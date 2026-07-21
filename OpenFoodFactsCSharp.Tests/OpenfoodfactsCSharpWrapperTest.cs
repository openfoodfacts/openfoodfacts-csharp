using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using OpenFoodFactsCSharp.Clients;
using OpenFoodFactsCSharp.Services;
using Xunit;
using Xunit.Abstractions;

namespace OpenFoodFactsCSharp.Tests
{
    public class OpenfoodfactsCSharpWrapperTest(ITestOutputHelper output)
    {
        private readonly OpenFoodFactsWrapperImpl service = new(new OpenFoodFactsApiLowLevelClient(new HttpClient()));
        private readonly ITestOutputHelper _output = output;

        [Fact]
        public void TestApplicationIsRunning()
        {
            Assert.True(true);
        }

        [Fact]
        public async Task TestFetchProductByCodeWithExampleData()
        {
            var productCode = "0013764027053";

            var productResponse = await service.FetchProductByCodeAsync(productCode);
            //var statusCode = productResponse.Status;
            //var searchResult = productResponse.Result;

            Assert.NotNull(productResponse);
            Assert.Equal(productCode, productResponse.Code);
            Assert.Equal("Dave's Killer Bread", productResponse.Product.Brands);
            Assert.Equal("Organic Bread 21 Whole Grains and Seeds", productResponse.Product.ProductName);
        }
    }
}