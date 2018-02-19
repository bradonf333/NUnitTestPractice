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

        [Test]
        public void ShouldJoinNames_CaseInsensitive()
        {
            var sut = new NameJoinerDemo();

            var fullName = sut.Join("sarah", "smith");

            Assert.That(fullName, Is.EqualTo("Sarah Smith").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqual()
        {
            var sut = new NameJoinerDemo();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Is.Not.EqualTo("Bob Sap"));
        }
    }
}
