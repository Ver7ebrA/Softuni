using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (0 < number)
            {
                sum += number % 10;
                number = number / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
