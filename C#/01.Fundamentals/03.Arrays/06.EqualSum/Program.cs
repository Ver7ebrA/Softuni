using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rigthSum = 0;
            int element = 0;
            bool equalSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = numbers.Length - 1; k > i; k--)
                {
                    rigthSum += numbers[k];
                }

                if (leftSum == rigthSum)
                {
                    element = i;
                    equalSums = true;
                }

                leftSum = 0;
                rigthSum = 0;
            }

            if (equalSums == true)
            {
                Console.WriteLine(element);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
