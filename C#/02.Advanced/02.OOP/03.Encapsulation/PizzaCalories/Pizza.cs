using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || (value.Length < 1 && 15 < value.Length))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public int NumberOFToppings
        {
            get
            {
                return this.toppings.Count;
            }
        }

        public double GetCalories
        {
            get
            {
                return this.TotalCalories();
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        private double TotalCalories()
        {
            double calories = this.dough.GetCalories;

            foreach (var topping in this.toppings)
            {
                calories += topping.GetCalories;
            }

            return calories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.GetCalories:f2} Calories.";
        }
    }
}
