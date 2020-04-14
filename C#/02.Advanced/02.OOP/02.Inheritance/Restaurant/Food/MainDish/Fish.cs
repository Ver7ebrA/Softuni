using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.MainDish
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price)
            : base(name, price, 22d)
        {

        }
    }
}
