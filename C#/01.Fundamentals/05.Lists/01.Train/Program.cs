using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPassengersPerWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] inputArr = input.Split();

                if (inputArr[0] == "Add")
                {
                    int wagon = int.Parse(inputArr[1]);
                    wagons.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(inputArr[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxPassengersPerWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
