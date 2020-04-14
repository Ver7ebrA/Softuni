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

            bool changes = false;

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
                    changes = true;
                }
                else if (inputArr[0] == "Remove")
                {
                    int number = int.Parse(inputArr[1]);
                    numbers.Remove(number);
                    changes = true;
                }
                else if (inputArr[0] == "RemoveAt")
                {
                    int index = int.Parse(inputArr[1]);
                    numbers.RemoveAt(index);
                    changes = true;
                }
                else if (inputArr[0] == "Insert")
                {
                    int number = int.Parse(inputArr[1]);
                    int index = int.Parse(inputArr[2]);
                    numbers.Insert(index, number);
                    changes = true;
                }
                else if (inputArr[0] == "Contains")
                {
                    int number = int.Parse(inputArr[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (inputArr[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (inputArr[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (inputArr[0] == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (inputArr[0] == "Filter")
                {
                    int number = int.Parse(inputArr[2]);

                    if (inputArr[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (inputArr[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (inputArr[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (inputArr[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                }

            }

            if (changes == true)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
