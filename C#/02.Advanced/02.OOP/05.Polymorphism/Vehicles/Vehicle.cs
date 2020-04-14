using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;

            if (this.TankCapacity < fuelQuantity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }

            this.FuelConsumption = fuelConsumption;

        }

        protected double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }


        protected abstract double AdditionalFuelConsumption { get; }

        public string Drive(double distance)
        {
            double requiredFuel = distance * (this.FuelConsumption + this.AdditionalFuelConsumption);

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.TankCapacity < this.FuelQuantity + fuel)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += fuel;
            }          
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
