using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            while(heroes.Count < numberOfHeroes)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    BaseHero newHero = HeroFactory.Build(heroType, heroName);
                    heroes.Add(newHero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int heroesPower = 0;

            if (0 < heroes.Count)
            {
                foreach (var hero in heroes)
                {
                    heroesPower += hero.Power;
                    Console.WriteLine(hero.CastAbility());
                }
            }

            if (bossPower <= heroesPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
