using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double result = FactorialDivision(number1, number2);
            Console.WriteLine($"{result:f2}");
        }

        static double FactorialDivision(int a, int b)
        {
            double factA = (double)a;
            double factB = (double)b;

            for (int i = a - 1; i > 0; i--)
            {
                factA *= i;
            }

            for (int i = b - 1; i > 0; i--)
            {
                factB *= i;
            }

            return (factA / factB);
        }
    }
}
