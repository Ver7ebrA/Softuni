using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int quantity = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input <= capacity)
                {
                    capacity -= input;
                    quantity += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(quantity);
        }
    }
}
