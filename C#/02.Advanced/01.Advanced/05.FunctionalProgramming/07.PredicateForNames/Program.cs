using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> filter = s => s.Length <= neededLength;

            names = names.Where(filter).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
