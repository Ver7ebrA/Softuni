using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            Queue<Car> cars = new Queue<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineStats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (engineStats.Length == 2)
                {
                    Engine engine = new Engine(engineStats[0], int.Parse(engineStats[1]));
                    engines.Add(engine);
                }
                else if (engineStats.Length == 3)
                {
                    if (char.IsDigit(engineStats[2].FirstOrDefault()))
                    {
                        Engine engine = new Engine(engineStats[0], int.Parse(engineStats[1]), int.Parse(engineStats[2]));
                        engines.Add(engine);
                    }
                    else
                    {
                        Engine engine = new Engine(engineStats[0], int.Parse(engineStats[1]), engineStats[2]);
                        engines.Add(engine);
                    }                   
                }
                else if (engineStats.Length == 4)
                {
                    Engine engine = new Engine(engineStats[0], int.Parse(engineStats[1]), int.Parse(engineStats[2]), engineStats[3]);
                    engines.Add(engine);
                }
               
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carStats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (carStats.Length == 2)
                {
                    Car car = new Car(carStats[0], engines.Where(e => e.Model == carStats[1]).FirstOrDefault());
                    cars.Enqueue(car);
                }
                else if (carStats.Length == 3)
                {
                    if (char.IsDigit(carStats[2].FirstOrDefault()))
                    {
                        Car car = new Car(carStats[0], engines.Where(e => e.Model == carStats[1]).FirstOrDefault(), int.Parse(carStats[2]));
                        cars.Enqueue(car);
                    }
                    else
                    {
                        Car car = new Car(carStats[0], engines.Where(e => e.Model == carStats[1]).FirstOrDefault(), carStats[2]);
                        cars.Enqueue(car);
                    }
                }
                else if (carStats.Length == 4)
                {
                    Car car = new Car(carStats[0],
                        engines.Where(e => e.Model == carStats[1]).FirstOrDefault(),
                        int.Parse(carStats[2]),
                        carStats[3]);
                    cars.Enqueue(car);
                }
            }

            while (cars.Any())
            {
                Car currentCar = cars.Dequeue();
                Console.WriteLine(currentCar.ToString());
            }
        }
    }
}
