using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine()
                                .Split('|')
                                .Reverse()
                                .ToList();

            List<int> numbers = new List<int>();
            foreach (var str in numbersAsStrings)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );

            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
