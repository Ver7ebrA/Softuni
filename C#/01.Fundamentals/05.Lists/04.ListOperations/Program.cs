using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOperations
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

                if (input == "End")
                {
                    break;
                }

                string[] inputArr = input.Split();

                if (inputArr[0] == "Add")
                {
                    int number = int.Parse(inputArr[1]);
                    numbers.Add(number);
                }
                else if (inputArr[0] == "Insert")
                {
                    int index = int.Parse(inputArr[2]);

                    if ((numbers.Count - 1) < index || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int number = int.Parse(inputArr[1]);
                        numbers.Insert(index, number);
                    }
                }
                else if (inputArr[0] == "Remove")
                {
                    int index = int.Parse(inputArr[1]);

                    if ((numbers.Count - 1) < index || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (inputArr[0] == "Shift")
                {
                    int count = int.Parse(inputArr[2]);

                    if (inputArr[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int number = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(number);
                        }
                    }
                    else if (inputArr[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int number = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, number);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
