using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArr = input.Split(", ");

                if (inputArr[0] == "IN")
                {
                    cars.Add(inputArr[1]);
                }
                else if (inputArr[0] == "OUT" && cars.Contains(inputArr[1]))
                {
                    cars.Remove(inputArr[1]);
                }

                input = Console.ReadLine();
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
