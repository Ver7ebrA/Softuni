using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> dividable = new Predicate<int>(n => n % divider != 0);
            Func<int, bool> myFunc = i => dividable(i);

            numbers = numbers.Reverse().Where(myFunc);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
