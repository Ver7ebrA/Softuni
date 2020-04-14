using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numsForStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(numsForStack);

            for (int i = 0; i < input[1]; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (0 < numbers.Count)
                {
                    int smallestNumber = int.MaxValue;
                    while (numbers.Any())
                    {
                        int currentNumber = numbers.Pop();
                        if (currentNumber < smallestNumber)
                        {
                            smallestNumber = currentNumber;
                        }
                    }

                    Console.WriteLine(smallestNumber);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
