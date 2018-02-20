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

        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveLongBowDefaultWeapon()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }

        [Test]
        public void ShouldHaveAtLeastOneTypeOfSword()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Has.Some.Contains("Sword"));
        }

        [Test]
        public void ShouldHaveExactlyTwoBows()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }

        [Test]
        public void ShouldHaveOnlyOneOfEachItem()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Is.Unique);
        }

        [Test]
        public void ShouldNotHaveStaffOfPower()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Has.None.EqualTo("Staff Of Wonder"));
        }

        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();

            var expectedWeapons = new[]
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
            };

            Assert.That(sut.Weapons, Is.EquivalentTo(expectedWeapons));
        }

        [Test]
        public void ShouldHaveDefaultWeaponsInAlphabeticalOrder()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Is.Ordered);
        }

        [Test]
        public void ShouldHaveDifferentReferences()
        {
            var player1Sut = new PlayerCharacter();
            var player2Sut = new PlayerCharacter();

            Assert.That(player1Sut, Is.Not.SameAs(player2Sut));
        }

        [Test]
        public void ShouldHaveSameReferences()
        {
            var player1Sut = new PlayerCharacter();
            var player2Sut = player1Sut;

            Assert.That(player1Sut, Is.SameAs(player2Sut));
        }
    }
}
