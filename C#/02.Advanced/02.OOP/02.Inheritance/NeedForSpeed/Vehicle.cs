using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double defaultFuelConsumption;
        private double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }

        public double DefaultFuelConsumption
        {
            get
            {
                return this.defaultFuelConsumption;
            }
            set
            {
                this.defaultFuelConsumption = value;
            }
        }

        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * this.FuelConsumption);
        }
    }
}
