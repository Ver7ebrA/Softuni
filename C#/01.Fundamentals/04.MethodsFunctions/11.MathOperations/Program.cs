using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculate(a, command, b);
            Console.WriteLine($"{result}");
        }

        static double Calculate(int a, string command, int b)
        {
            double result = 0;

            if (command == "+")
            {
                result = a + b;
            }
            else if (command == "-")
            {
                result = a - b;
            }
            else if (command == "*")
            {
                result = a * b;
            }
            else if (command == "/")
            {
                double a1 = (double)a;
                result = a1 / b;
            }

            return result;
        }
    }
}
