using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonTests
{
    public class DummyTests : ITarget
    {
        public int Health => throw new NotImplementedException();

        [Test]

        public void DummyLosesHealthAfterAttack()
        {
            var initialHealth = 10;
            var attackToTake = 5;
            var expectedHealth = 5;

            var dummy = new Dummy(initialHealth, attackToTake);

            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(expectedHealth));
        }

        public int GiveExperience()
        {
            throw new NotImplementedException();
        }

        public bool IsDead()
        {
            throw new NotImplementedException();
        }

        public void TakeAttack(int attackPoints)
        {
            throw new NotImplementedException();
        }
    }
}
