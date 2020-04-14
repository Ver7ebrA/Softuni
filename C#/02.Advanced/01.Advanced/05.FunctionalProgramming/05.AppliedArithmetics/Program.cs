using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> adder = x => x.Select(y => y + 1).ToArray();
            Func<int[], int[]> multiplier = x => x.Select(y => y * 2).ToArray();
            Func<int[], int[]> subtractor = x => x.Select(y => y - 1).ToArray();
            Func<int[], string> printer = x => String.Join(" ", x);

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = adder(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiplier(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractor(numbers);
                }
                else if (command == "print")
                {
                    Console.WriteLine(printer(numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}
