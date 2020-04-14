using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ListManupulationBasics
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

                string[] inputArr = input.Split();

                if (inputArr[0] == "Add")
                {
                    int number = int.Parse(inputArr[1]);
                    numbers.Add(number);
                }
                else if (inputArr[0] == "Remove")
                {
                    int number = int.Parse(inputArr[1]);
                    numbers.Remove(number);
                }
                else if (inputArr[0] == "RemoveAt")
                {
                    int index = int.Parse(inputArr[1]);
                    numbers.RemoveAt(index);
                }
                else if (inputArr[0] == "Insert")
                {
                    int number = int.Parse(inputArr[1]);
                    int index = int.Parse(inputArr[2]);
                    numbers.Insert(index, number);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
