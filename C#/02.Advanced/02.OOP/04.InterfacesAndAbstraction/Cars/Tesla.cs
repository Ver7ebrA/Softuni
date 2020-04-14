using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car, ICar, IElectricCar
    {
        private int Battery;

        public Tesla(string model, string color, int battery) : base(model, color)
        {
            this.Battery = battery;
        }

        public int Baterry { get; private set; }

        protected override string GetCarInfo()
        {
            return base.GetCarInfo() + $" with {this.Battery} Batteries";
        }
    }
}
