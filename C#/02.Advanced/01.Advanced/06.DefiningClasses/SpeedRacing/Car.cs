using System;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0.0;
        }

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * this.fuelConsumptionPerKilometer;

            if (fuelNeeded <= this.fuelAmount)
            {
                this.fuelAmount -= fuelNeeded;
                this.travelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
