using NUnit.Framework;
using System;

namespace MemoryCalculatorApp.Tests
{
    [TestFixture]
    public class MemoryCalculatorAppTests
    {
        MemoryCalculator sut = new MemoryCalculator();

        [SetUp]
        public void BeforeEachTest()
        {
            sut = new MemoryCalculator();
        }

        [Test]
        public void ShouldAdd()
        {
            sut.Add(10);
            sut.Add(5);

            Assert.That(sut.CurrentValue, Is.EqualTo(15));
        }

        [Test]
        public void ShouldSubtract()
        {
            sut.Subtract(5);

            Assert.That(sut.CurrentValue, Is.EqualTo(-5));
        }
    }
}
