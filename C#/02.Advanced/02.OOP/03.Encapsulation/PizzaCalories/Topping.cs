using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BASE_CALORIES_PER_GRAM = 2.0;
        private const double MEAT_MODIFIER = 1.2;
        private const double VEGGIES_MODIFIER = 0.8;
        private const double CHEESE_MODIFIER = 1.1;
        private const double SAUCE_MODIFIER = 0.9;

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private int Weight
        {
            set
            {
                if (value < 0 || 50 < value)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private double Calories()
        {
            double calories = this.weight * BASE_CALORIES_PER_GRAM;

            if (this.type.ToLower() == "meat")
            {
                calories *= MEAT_MODIFIER;
            }
            else if (this.type.ToLower() == "veggies")
            {
                calories *= VEGGIES_MODIFIER;
            }
            else if (this.type.ToLower() == "cheese")
            {
                calories *= CHEESE_MODIFIER;
            }
            else if (this.type.ToLower() == "sauce")
            {
                calories *= SAUCE_MODIFIER;
            }

            return calories;
        }

        public double GetCalories
        {
            get
            {
                return this.Calories();
            }
        }
    }
}
