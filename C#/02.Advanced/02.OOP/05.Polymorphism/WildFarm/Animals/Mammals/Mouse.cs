using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.1;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        protected override void ValidateFood(Food food)
        {
            if (!(food is Vegetable) && !(food is Fruit))
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
