using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();

            if (3 <= sortedNumbers.Length)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(String.Join(" ", sortedNumbers));
            }
        }
    }
}
