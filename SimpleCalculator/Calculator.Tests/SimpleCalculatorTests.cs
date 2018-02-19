using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoInts()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddInts(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldAddTwoDoubles()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.Not.EqualTo(3.3));
        }

        [Test]
        public void ShouldAddTwoDoubles_WithTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddTwoDoubles_WithPercentTolerance()
        {
            var sut = new SimpleCalculator();

            var result = sut.AddDoubles(50, 50);

            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }
    }
}
