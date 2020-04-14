using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }



            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
