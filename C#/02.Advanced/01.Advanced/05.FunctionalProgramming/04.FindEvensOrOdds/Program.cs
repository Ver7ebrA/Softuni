using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine();
            Predicate<int> predicate = null;

            if (condition == "odd")
            {
                predicate = new Predicate<int>(n => n % 2 != 0);
            }
            else if (condition == "even")
            {
                predicate = new Predicate<int>(n => n % 2 == 0);
            }

            List<int> result = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
