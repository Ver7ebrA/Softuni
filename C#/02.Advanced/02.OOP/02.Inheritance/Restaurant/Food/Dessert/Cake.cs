using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.Dessert
{
    public class Cake : Dessert
    {

        public Cake(string name)s
            : base(name, 5m, 250d, 1000d)
        {
        }
    }
}
