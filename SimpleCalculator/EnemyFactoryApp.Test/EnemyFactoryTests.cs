using EnemyFactorApp;
using NUnit.Framework;
using System;

namespace EnemyFactoryApp.Test
{
    [TestFixture]
    public class EnemyFactoryTests
    {
        [Test]
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            Assert.That(enemy, Is.TypeOf<NormalEnemy>());
        }

        [Test]
        public void ShouldCreateBossEnemy()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(true);

            Assert.That(enemy, Is.TypeOf<BossEnemy>());
        }
    }
}
