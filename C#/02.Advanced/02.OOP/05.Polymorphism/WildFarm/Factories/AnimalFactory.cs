using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;

namespace WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static Animal Create(string[] args)
        {
            string type = args[0];
            if (type == "Owl")
            {
                return new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
            }
            else if (type == "Hen")
            {
                return new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
            }
            else if (type == "Mouse")
            {
                return new Mouse(args[1], double.Parse(args[2]), args[3]);
            }
            else if (type == "Dog")
            {
                return new Dog(args[1], double.Parse(args[2]), args[3]);
            }
            else if (type == "Cat")
            {
                return new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
            }
            else if (type == "Tiger")
            {
                return new Tiger(args[1], double.Parse(args[2]), args[3], args[4]);
            }
            else
            {
                throw new ArgumentException("Invalid animal!");
            }
        }
    }
}
