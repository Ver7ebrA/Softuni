using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        protected abstract double WeightPerFood { get; }

        protected string Name { get; private set; }

        protected double Weight { get; set; }

        protected int FoodEaten { get; set; }

        public abstract string ProduceSound();

        protected abstract void ValidateFood(Food food);

        protected void Throw(Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        public void EatFood(Food food)
        {
            this.ValidateFood(food);

            this.FoodEaten += food.Quantiy;
            this.Weight += food.Quantiy * WeightPerFood;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
