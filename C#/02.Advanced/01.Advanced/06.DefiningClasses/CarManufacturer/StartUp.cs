using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            while (input != "No more tires")
            {
                var cmdArgs = input.Split();
                var currTires = new Tire[4]
                {
                new Tire(int.Parse(cmdArgs[0]),double.Parse(cmdArgs[1])),
                new Tire(int.Parse(cmdArgs[2]),double.Parse(cmdArgs[3])),
                new Tire(int.Parse(cmdArgs[4]),double.Parse(cmdArgs[5])),
                new Tire(int.Parse(cmdArgs[6]),double.Parse(cmdArgs[7]))

                };
                tires.Add(currTires);
                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2 != "Engines done")
            {
                var cmdArgs = input2.Split();
                var currHP = int.Parse(cmdArgs[0]);
                var curCubic = double.Parse(cmdArgs[1]);
                engines.Add(new Engine(currHP, curCubic));
                input2 = Console.ReadLine();
            }
            string input3 = Console.ReadLine();
            while (input3 != "Show special")
            {
                var cmdArgs = input3.Split();
                var make = cmdArgs[0];
                var model = cmdArgs[1];
                var year = int.Parse(cmdArgs[2]);
                var fuelQuantity = int.Parse(cmdArgs[3]);
                var fuelConsumption = int.Parse(cmdArgs[4]);
                var engineIndex = int.Parse(cmdArgs[5]);
                var tiresIndex = int.Parse(cmdArgs[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
                input3 = Console.ReadLine();
            }



            foreach (var currenCar in cars)
            {
                bool manyfYear = false;
                bool hp = false;
                bool pres = false;
                double totV = 0;
                if (currenCar.Year >= 2017)
                {
                    manyfYear = true;
                }
                if (currenCar.Engine.HorsePower >= 330)
                {
                    hp = true;
                }
                foreach (var currTires in currenCar.Tires)
                {
                    double value = currTires.Pressure;
                    totV = totV + value;
                }
                if (totV >= 9 && totV <= 10)
                {
                    pres = true;
                }
                if (manyfYear && hp && pres)
                {
                    currenCar.Drive(20);
                    Console.WriteLine($"Make: {currenCar.Make}\nModel: {currenCar.Model}\nYear: {currenCar.Year}\nHorsePowers: {currenCar.Engine.HorsePower}\nFuelQuantity: {currenCar.FuelQuantity}");
                }
            }
        }
    }
}
