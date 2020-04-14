using System;

namespace _02.CharacterMultyplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            int sum = 0;
            int minLength = Math.Min(strings[0].Length, strings[1].Length);
            string longerString = string.Empty;

            if (strings[0].Length < strings[1].Length)
            {
                longerString = strings[1];
            }
            else if (strings[1].Length < strings[0].Length)
            {
                longerString = strings[0];
            }

            for (int i = 0; i < minLength; i++)
            {
                sum += strings[0][i] * strings[1][i];
            }

            for (int i = minLength; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
