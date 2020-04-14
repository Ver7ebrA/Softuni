using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine()).ToLower();
            VowelsCount(input);
        }

        static void VowelsCount(string word)
        {
            int count = 0;
            string[] letters = word.Select(t => t.ToString()).ToArray();

            foreach (string letter in letters)
            {
                if (letter == "a" ||
                    letter == "e" ||
                    letter == "u" ||
                    letter == "i" ||
                    letter == "o")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
