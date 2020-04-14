using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private const int PISTOL_BULLETS_FIRE = 1;

        public Pistol(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (0 <= this.BulletsCount - PISTOL_BULLETS_FIRE)
            {
                this.BulletsCount -= PISTOL_BULLETS_FIRE;

                return PISTOL_BULLETS_FIRE;
            }

            return 0;
        }
    }
}
