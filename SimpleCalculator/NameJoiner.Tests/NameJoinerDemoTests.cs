using System;
using NUnit.Framework;

namespace NameJoiner.Tests
{
    [TestFixture]
    public class NameJoinerDemoTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoinerDemo();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Is.EqualTo("Sarah Smith"));
        }
    }
}
