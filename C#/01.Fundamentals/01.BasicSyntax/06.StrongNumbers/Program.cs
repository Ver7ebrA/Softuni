using System;

namespace _06.StrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = number.ToString();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int num = (int)Char.GetNumericValue(input[i]);
            }
        }
    }
}
