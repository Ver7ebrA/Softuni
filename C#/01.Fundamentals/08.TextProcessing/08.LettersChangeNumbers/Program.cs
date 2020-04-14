using System;
using System.Linq;
using System.Text;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                string numberAsString = item.Substring(1, item.Length - 2);
                double number = double.Parse(numberAsString);

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    number /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    number *= position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    number -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    number += position;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
