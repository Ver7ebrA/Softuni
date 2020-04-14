using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double ADDITIONAL_FUEL_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double AdditionalFuelConsumption => ADDITIONAL_FUEL_CONSUMPTION;
    }
}
