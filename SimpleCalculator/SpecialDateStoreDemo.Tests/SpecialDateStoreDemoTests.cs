using NUnit.Framework;
using System;

namespace SpecialDateStoreDemo.Tests
{
    [TestFixture]
    public class SpecialDateStoreDemoTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SepcialDateStore();

            var result = sut.DateOf(SpecialDates.NewMillennium);

            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void ShouldHaveIncorrectMilleniumDateMillisecond()
        {
            var sut = new SepcialDateStore();

            var result = sut.DateOf(SpecialDates.NewMillennium);

            Assert.That(result, Is.Not.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTolerance()
        {
            var sut = new SepcialDateStore();

            var result = sut.DateOf(SpecialDates.NewMillennium);

            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1))
                                  .Within(TimeSpan.FromMilliseconds(1)));
        }
    }
}
