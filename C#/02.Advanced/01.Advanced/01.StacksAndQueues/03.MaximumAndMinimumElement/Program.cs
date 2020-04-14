using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (input[0] == 1)
                {
                    sequence.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    if (0 < sequence.Count)
                    {
                        sequence.Pop();
                    }
                }
                else if (input[0] == 3 && 0 < sequence.Count)
                {
                    Stack<int> tempSequence = new Stack<int>(sequence);
                    int maxElement = int.MinValue;
                    while (tempSequence.Any())
                    {
                        int currentElement = tempSequence.Pop();
                        if (maxElement < currentElement)
                        {
                            maxElement = currentElement;
                        }
                    }

                    Console.WriteLine(maxElement);
                }
                else if (input[0] == 4 && 0 < sequence.Count)
                {
                    Stack<int> tempSequence = new Stack<int>(sequence);
                    int minElement = int.MaxValue;
                    while (tempSequence.Any())
                    {
                        int currentElement = tempSequence.Pop();
                        if (currentElement < minElement)
                        {
                            minElement = currentElement;
                        }
                    }

                    Console.WriteLine(minElement);
                }
            }

            Console.WriteLine(String.Join(", ", sequence));
        }
    }
}
