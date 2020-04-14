using System;
using System.Linq;

namespace _07.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequence = 1;
            int longestSequence = 1;
            int sequenceElement = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i +1])
                {
                    sequence += 1;
                }
                else
                {
                    sequence = 1;
                }

                if (longestSequence < sequence)
                {
                    longestSequence = sequence;
                    sequenceElement = numbers[i];
                }
            }

            int[] arrSequence = new int[longestSequence];

            for (int i = 0; i < arrSequence.Length; i++)
            {
                arrSequence[i] = sequenceElement;
            }

            Console.WriteLine(String.Join(" ", arrSequence));
        }
    }
}
