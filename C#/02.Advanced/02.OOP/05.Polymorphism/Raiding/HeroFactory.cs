using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public static class HeroFactory
    {
        public static BaseHero Build(string heroType, string name)
        {
            if (heroType == "Druid")
            {
                return new Druid(name);
            }
            else if (heroType == "Paladin")
            {
                return new Paladin(name);
            }
            else if (heroType == "Rogue")
            {
                return new Rogue(name);
            }
            else if (heroType == "Warrior")
            {
                return new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }                  
        }
    }
}
