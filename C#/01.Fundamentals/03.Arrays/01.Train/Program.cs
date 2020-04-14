using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];
            int passengersSum = 0;
            for (int i = 0; i < wagons; i++)
            {
                int input = int.Parse(Console.ReadLine());
                passengers[i] = input;
                passengersSum += input;

                Console.Write(passengers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(passengersSum);
        }
    }
}
