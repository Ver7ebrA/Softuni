using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double ADDITIONAL_FUEL_CONSUMPTION = 1.4;

        private AirConditioner airConditioner;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.airConditioner = AirConditioner.On;
        }

        protected override double AdditionalFuelConsumption =>
            this.airConditioner == AirConditioner.On ?
            ADDITIONAL_FUEL_CONSUMPTION : (double)AirConditioner.Off;
        
        public void TurnOnAirConditioner()
        {
            this.airConditioner = AirConditioner.On;
        }

        public void TurOffAirConditioner()
        {
            this.airConditioner = AirConditioner.Off;
        }
    }
}
