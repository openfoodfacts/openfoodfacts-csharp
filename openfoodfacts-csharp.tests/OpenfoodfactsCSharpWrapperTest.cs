using pl.coderion.service.impl;
using Xunit;

namespace OpenFoodFactsCSharp.Tests
{
    public class OpenfoodfactsCSharpWrapperTest
    {
        private readonly pl.coderion.service.impl.OpenFoodFactsWrapperImpl service;

        public OpenfoodfactsCSharpWrapperTest()
        {
            // Initialize the service here, you might want to mock its dependencies
            // or use any DI mechanism your project utilizes.
            service = new OpenFoodFactsWrapperImpl(new pl.coderion.client.OpenFoodFactsApiLowLevelClient(new System.Net.Http.HttpClient()));
        }

        [Fact]
        public void TestApplicationIsRunning()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestFetchProductByCodeWithExampleData()
        {
            var productCode = "11252887";
            var productResponse = service.FetchProductByCodeAsync(productCode).Result;

            Assert.NotNull(productResponse);
            Assert.Equal(productCode, productResponse.Code);
            Assert.Equal("Sweet Baby Ray's", productResponse.Product.brands);
            Assert.Equal("Barbecue sauce", productResponse.Product.productName);
        }
    }
}
