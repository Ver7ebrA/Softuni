using System;

namespace _07.ReapeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            string result = RepeatString(input, repeatCount);
            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
