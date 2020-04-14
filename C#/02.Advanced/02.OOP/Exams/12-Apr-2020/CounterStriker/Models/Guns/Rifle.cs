using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private const int RIFLE_BULLETS_FIRE = 10;

        public Rifle(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (0 <= (this.BulletsCount - RIFLE_BULLETS_FIRE))
            {
                this.BulletsCount -= RIFLE_BULLETS_FIRE;

                return RIFLE_BULLETS_FIRE;
            }

            return 0;
        }
    }
}
