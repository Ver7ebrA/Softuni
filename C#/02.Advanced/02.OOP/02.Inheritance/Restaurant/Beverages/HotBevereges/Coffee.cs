using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.HotBevereges
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50d;
        private const decimal CoffeePrice = 3.5m;

        private double caffeine;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; }

    }
}
