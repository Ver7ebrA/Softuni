using System;
using System.Linq;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultiplyOfSums(input);
            Console.WriteLine(result);
        }

        static int MultiplyOfSums(int number)
        {
            int evenSum = EvenSum(number);
            int oddSum = OddSum(number);

            return evenSum * oddSum;
        }

        static int EvenSum(int number)
        {
            int evenSum = 0;
            int[] digitsArr = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            foreach (int digit in digitsArr)
            {
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
            }

            return evenSum;
        }

        static int OddSum(int number)
        {
            int oddSum = 0;
            int[] digitsArr = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            foreach (int digit in digitsArr)
            {
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
            }

            return oddSum;
        }
    }
}
