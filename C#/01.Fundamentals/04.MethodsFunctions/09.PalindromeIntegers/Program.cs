using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int num = int.Parse(input);
                bool result = PalindromeNumber(num);

                if (result == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }

        static bool PalindromeNumber(int number)
        {
            int numberOriginal = number;
            int reverse = 0;

            while (number > 0)
            {
                int r = number % 10;
                reverse = reverse * 10 + r;
                number /= 10;
            }

            if (reverse == numberOriginal)
            {
                return true;
            }

            return false;
        }
    }
}
