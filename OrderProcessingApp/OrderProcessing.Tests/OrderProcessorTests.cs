using Moq;
using NUnit.Framework;
using OrderProcessing;

namespace OrderProcessing.Tests
{
    [TestFixture]
    public class OrderProcessorTests
    {
        [Test]
        public void ProcessOrder_ShouldCallPlaceOrderWithCorrectParameters()
        {
            var orderServiceMock = new Mock<IOrderService>();
            var orderProcessor = new OrderProcessor(orderServiceMock.Object);

            orderProcessor.ProcessOrder("ProductABC", 3);

            orderServiceMock.Verify(os => os.PlaceOrder("ProductABC", 3), Times.Once);
        }

        [Test]
        public void ProcessOrder_ShouldCallPlaceOrderMultipleTimes()
        {
            var orderServiceMock = new Mock<IOrderService>();
            var orderProcessor = new OrderProcessor(orderServiceMock.Object);

            orderProcessor.ProcessOrder("Product1", 2);
            orderProcessor.ProcessOrder("Product2", 5);

            orderServiceMock.Verify(os => os.PlaceOrder("Product1", 2), Times.Once);
            orderServiceMock.Verify(os => os.PlaceOrder("Product2", 5), Times.Once);
        }
    }
}
