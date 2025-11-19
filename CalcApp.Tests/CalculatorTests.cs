using Assignment3_S29927;
using NUnit.Framework;

namespace Assignment3_S29927_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void TestAdd()
            => Assert.That(calc.Add(5, 3), Is.EqualTo(8));

        [Test]
        public void TestSubtract()
            => Assert.That(calc.Subtract(10, 4), Is.EqualTo(6));

        [Test]
        public void TestMultiply()
            => Assert.That(calc.Multiply(6, 7), Is.EqualTo(42));

        [Test]
        public void TestDivide()
            => Assert.That(calc.Divide(20, 4), Is.EqualTo(5));

        [Test]
        public void TestDivideByZero()
            => Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));

        [Test]
        public void TestAddWithNegativeNumbers()
            => Assert.That(calc.Add(-5, 3), Is.EqualTo(-2));

        [Test]
        public void TestMultiplyByZero()
            => Assert.That(calc.Multiply(7, 0), Is.EqualTo(0));

        [Test]
        public void TestDivideReturnsDoubleResult()
            => Assert.That(calc.Divide(1, 2), Is.EqualTo(0.5).Within(0.0001));
    }
}