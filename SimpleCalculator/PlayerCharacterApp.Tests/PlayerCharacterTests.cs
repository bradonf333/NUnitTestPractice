using NUnit.Framework;
using System;

namespace PlayerCharacterApp.Tests
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            Assert.That(sut.Health, Is.GreaterThan(100));
        }

        [Test]
        public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            Assert.That(sut.Health, Is.InRange(101, 200));
        }

        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Name, Is.Not.Empty);
        }

        [Test]
        public void ShouldHaveDefaultNullNickName()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.NickName, Is.Null);
        }

        [Test]
        public void ShouldBeNoob()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.IsNoob, Is.True);
        }
    }
}
