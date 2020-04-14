using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);

                    numbers.RemoveAll(n => n == number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
