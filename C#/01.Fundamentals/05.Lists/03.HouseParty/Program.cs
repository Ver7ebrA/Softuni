using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split();

                if (inputArr[2] == "going!")
                {
                    if (guests.Contains(inputArr[0]))6
                    {
                        Console.WriteLine($"{inputArr[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(inputArr[0]);
                    }
                }
                else if (inputArr[2] == "not")
                {
                    if (guests.Contains(inputArr[0]))
                    {
                        guests.Remove(inputArr[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{inputArr[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
