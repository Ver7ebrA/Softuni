using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArg = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carArg[1]), double.Parse(carArg[2]), double.Parse(carArg[3]));

            string[] truckArg = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckArg[1]), double.Parse(truckArg[2]), double.Parse(truckArg[3]));

            string[] busArg = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(busArg[1]), double.Parse(busArg[2]), double.Parse(busArg[3]));

            int numberOfCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] commandArg = Console.ReadLine().Split();

                double methodArg = double.Parse(commandArg[2]);
                if (commandArg[0] == "Drive")
                {
                    if (commandArg[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(methodArg));
                    }
                    else if (commandArg[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(methodArg));
                    }
                    else if (commandArg[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(methodArg));
                    }
                }
                else if (commandArg[0] == "Refuel")
                {
                    try
                    {
                        if (commandArg[1] == "Car")
                        {
                            car.Refuel(methodArg);
                        }
                        else if (commandArg[1] == "Truck")
                        {
                            truck.Refuel(methodArg);
                        }
                        else if (commandArg[1] == "Bus")
                        {
                            bus.Refuel(methodArg);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
                else if (commandArg[0] == "DriveEmpty" && commandArg[1] == "Bus")
                {
                    bus.TurOffAirConditioner();
                    Console.WriteLine(bus.Drive(methodArg));
                    bus.TurnOnAirConditioner();
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
