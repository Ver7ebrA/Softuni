using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumbers(a, b);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(a, b);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(a, b);
            }
            else if (command == "divide")
            {
                DivideNumbers(a, b);
            }
        }

        static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
