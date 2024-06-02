using FluentAssertions;
using TechTalk.SpecFlow;
using Moq;
using ProductProcessing;

namespace ProductProcessing.Tests.Features
{
    [Binding]
    public class ProductProcessorSteps
    {
        private string _product;
        private int _quantity;
        private Mock<IProductService> _productServiceMock;
        private ProductProcessor _productProcessor;

        [Given(@"I have a product ""(.*)"" with quantity (.*)")]
        public void GivenIHaveAProductWithQuantity(string product, int quantity)
        {
            _product = product;
            _quantity = quantity;
            _productServiceMock = new Mock<IProductService>();
            _productProcessor = new ProductProcessor(_productServiceMock.Object);
        }

        [When(@"I process the product")]
        public void WhenIProcessTheProduct()
        {
            _productProcessor.Process(_product, _quantity);
        }

        [Then(@"the product should be processed with quantity (.*)")]
        public void ThenTheProductShouldBeProcessedWithQuantity(int expectedQuantity)
        {
            _productServiceMock.Verify(ps => ps.ProcessProduct(_product, expectedQuantity), Times.Once);
        }
    }
}
