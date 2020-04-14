using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbersToQueue = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(numbersToQueue);

            for (int i = 0; i < input[1]; i++)
            {
                numbers.Dequeue();
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
                        int currentNumber = numbers.Dequeue();
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
