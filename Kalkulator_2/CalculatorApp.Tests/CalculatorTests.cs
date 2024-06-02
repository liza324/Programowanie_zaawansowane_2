using Moq;
using NUnit.Framework;
using CalculatorApp;
using NUnit.Framework.Legacy;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldSendDataToWebService()
        {
            var webServiceMock = new Mock<IWebService>();
            var calculator = new Calculator(webServiceMock.Object);

            int result = calculator.Add(3, 5);

            ClassicAssert.AreEqual(8, result);
            webServiceMock.Verify(ws => ws.SendData("Add operation: 3 + 5 = 8"), Times.Once);
        }
    }
}

