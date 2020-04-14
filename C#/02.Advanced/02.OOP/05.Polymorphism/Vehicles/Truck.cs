using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double ADDITIONAL_FUEL_CONSUMPTION = 1.6;
        private const double REFUELING_MODIFIER = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double AdditionalFuelConsumption => ADDITIONAL_FUEL_CONSUMPTION;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
            this.FuelQuantity -= (1 - REFUELING_MODIFIER) * fuel;
        }
    }
}
