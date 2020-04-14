using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<Car> cars = new Queue<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeigth = int.Parse(input[3]);
                string cargoType = input[4];
                double firstTirePressure = double.Parse(input[5]);
                int firstTireAge = int.Parse(input[6]);
                double secondTirePressure = double.Parse(input[7]);
                int secondTireAge = int.Parse(input[8]);
                double thirdTirePressure = double.Parse(input[9]);
                int thirdTireAge = int.Parse(input[10]);
                double fourthTirePressure = double.Parse(input[11]);
                int fourthTireAge = int.Parse(input[12]);

                Engine engine = new Engine(enginePower, engineSpeed);
                Cargo cargo = new Cargo(cargoType, cargoWeigth);
                Tire firstTire = new Tire(firstTirePressure, firstTireAge);
                Tire secondTire = new Tire(secondTirePressure, secondTireAge);
                Tire thirdTire = new Tire(thirdTirePressure, thirdTireAge);
                Tire fourthTire = new Tire(fourthTirePressure, fourthTireAge);
                Tire[] tires = new Tire[] {firstTire, secondTire, thirdTire, fourthTire};

                Car car = new Car(model, engine, cargo, tires);

                cars.Enqueue(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                while (cars.Any())
                {
                    Car currentCar = cars.Dequeue();

                    if (currentCar.Cargo.Type == command && currentCar.Tires.Any(t => t.Pressure < 1))
                    {
                        Console.WriteLine($"{currentCar.Model}");
                    }
                }
            }
            else if (command == "flamable")
            {
                while (cars.Any())
                {
                    Car currentCar = cars.Dequeue();

                    if (currentCar.Cargo.Type == command && currentCar.Engine.Power > 250)
                    {
                        Console.WriteLine($"{currentCar.Model}");
                    }
                }
            }
        }
    }
}
