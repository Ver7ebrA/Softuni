using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> evenNumbers = new List<int>();

            Queue<int> numbers = new Queue<int>(input);

            while (numbers.Any())
            {
                int currentNumber = numbers.Peek();
                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Add(currentNumber);
                    numbers.Dequeue();
                }
                else
                {
                    numbers.Dequeue();
                }
            }

            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
