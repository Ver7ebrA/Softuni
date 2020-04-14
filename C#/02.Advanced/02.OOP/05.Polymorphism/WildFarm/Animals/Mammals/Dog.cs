using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.4;

        public override string ProduceSound()
        {
            return "Woof!";
        }

        protected override void ValidateFood(Food food)
        {
            if (!(food is Meat))
            {
                this.Throw(food);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
