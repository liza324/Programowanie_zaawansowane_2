using NUnit.Framework;
using NUnit.Framework.Legacy;
using Kalkulator;

namespace Kalkulator.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        private Class1 _class1;

        [SetUp]
        public void Setup()
        {
            _class1 = new Class1();
        }

        [Test]
        public void Sum_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = _class1.Sum(3, 7);
            ClassicAssert.AreEqual(10, result);
        }

        [Test]
        public void Sum_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = _class1.Sum(5, -3);
            ClassicAssert.AreEqual(2, result);
        }

        [Test]
        public void Sum_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = _class1.Sum(-4, -6);
            ClassicAssert.AreEqual(-10, result);
        }

        [Test]
        public void Sum_ZeroAndNumber_ReturnsNumber()
        {
            int result = _class1.Sum(0, 5);
            ClassicAssert.AreEqual(5, result);
        }

        [Test]
        public void Sum_NumberAndZero_ReturnsNumber()
        {
            int result = _class1.Sum(7, 0);
            ClassicAssert.AreEqual(7, result);
        }
    }
}
