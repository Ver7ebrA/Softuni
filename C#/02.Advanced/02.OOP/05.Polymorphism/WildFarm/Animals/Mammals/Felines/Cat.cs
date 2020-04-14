using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 0.3;

        public override string ProduceSound()
        {
            return "Meow";
        }

        protected override void ValidateFood(Food food)
        {
            if (!(food is Vegetable) && !(food is Meat))
            {
                this.Throw(food);
            }
        }
    }
}
