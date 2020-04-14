using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = input[0];
            int bombNumberPower = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = Math.Max(0, i - bombNumberPower);
                    int end = Math.Min(numbers.Count - 1, i + bombNumberPower);

                    for (int k = start; k <= end; k++)
                    {
                        numbers[k] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
