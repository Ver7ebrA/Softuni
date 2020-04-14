﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.25;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        protected override void ValidateFood(Food food)
        {
            if (!(food is Meat))
            {
                this.Throw(food);
            }
        }
    }
}
