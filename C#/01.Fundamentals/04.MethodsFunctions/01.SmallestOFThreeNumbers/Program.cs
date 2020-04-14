using System;

namespace _01.SmallestOFThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            SmallestNumber(number1, number2, number3);
        }

        static void SmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }
            else if (a == b && a == c)
            {
                Console.WriteLine(a);
            }
        }
    }
}
