using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Factories
{
    public static class FoodFactory
    {
        public static Food Create(string[] args)
        {
            string type = args[0];
            int quantity = int.Parse(args[1]);
            if (type == "Fruit")
            {
                return new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                return new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                return new Seeds(quantity);
            }
            else if (type == "Vegetable")
            {
                return new Vegetable(quantity);
            }
            else
            {
                throw new ArgumentException("Invalid food!");
            }
        }
    }
}
