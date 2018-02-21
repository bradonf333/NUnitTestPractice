using NUnit.Framework;
using System;

namespace MemoryCalculatorApp.Tests
{
    [TestFixture]
    public class MemoryCalculatorAppTests
    {
        MemoryCalculator sut;

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);
            sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
            sut = null;
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
