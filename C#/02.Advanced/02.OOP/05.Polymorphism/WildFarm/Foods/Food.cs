using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Foods
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantiy = quantity;
        }
        public int Quantiy { get; private set; }
    }
}
