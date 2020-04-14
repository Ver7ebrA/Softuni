using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumResult = Sum(num1, num2);
            int subtractResult = Subtract(sumResult, num3);

            Console.WriteLine(subtractResult);
        }

        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }

        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
