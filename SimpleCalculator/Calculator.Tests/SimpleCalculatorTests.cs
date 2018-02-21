using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        SimpleCalculator sut = new SimpleCalculator();

        [Test]
        public void ShouldAddTwoInts()
        {
            var result = sut.AddInts(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldAddTwoDoubles()
        {
            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.Not.EqualTo(3.3));
        }

        [Test]
        public void ShouldAddTwoDoubles_WithTolerance()
        {
            var result = sut.AddDoubles(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddTwoDoubles_WithPercentTolerance()
        {
            var result = sut.AddDoubles(50, 50);

            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void ShouldThrowExceptionWhenDivideByZero()
        {
            Assert.That(() => sut.DivideInts(200, 0), Throws.Exception);
        }

        [Test]
        public void ShouldThrowDivideByZeroExceptionWhenDivideByZero()
        {
            Assert.That(() => sut.DivideInts(200, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void ShouldThrowOutOfRangeExceptionWhenGreaterThan200()
        {
            Assert.That(() => sut.DivideInts(201, 0), 
                Throws.TypeOf<ArgumentOutOfRangeException>()
                      .With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "a"));
        }
    }
}
