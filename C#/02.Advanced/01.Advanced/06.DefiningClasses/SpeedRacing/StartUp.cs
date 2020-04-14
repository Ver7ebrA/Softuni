using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = commandArr[1];
                double distance = double.Parse(commandArr[2]);

                Car currentCar = cars.Where(c => c.Model == carModel).FirstOrDefault();

                if (currentCar != null)
                {
                    currentCar.Drive(distance);
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
