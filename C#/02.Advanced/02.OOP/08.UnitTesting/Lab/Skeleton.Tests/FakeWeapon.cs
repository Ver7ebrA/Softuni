using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    public class FakeWeapon : IWeapon
    {
        private const int fakeAxeAttackPoints = 10;

        public FakeWeapon()
        {
            this.AttackPoints = fakeAxeAttackPoints;
        }
        public int AttackPoints { get; private set; }

        public int DurabilityPoints { get; }

        public void Attack(ITarget target)
        {
            target.TakeAttack(AttackPoints);
        }
    }
}
