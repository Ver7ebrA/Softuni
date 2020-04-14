using System;

namespace _02.KnigthsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = text => Console.WriteLine($"Sir {text}");

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
