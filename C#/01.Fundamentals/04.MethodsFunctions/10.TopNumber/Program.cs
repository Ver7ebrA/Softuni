using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumbers(number);
        }

        static void TopNumbers(int a)
        {
            bool divisibleByEigth = false;
            bool containsOddDigit = false;

            for (int i = 1; i <= a; i++)
            {
                int num = i;
                int sumOfDigits = 0;
                divisibleByEigth = false;
                containsOddDigit = false;


                while (0 < num)
                {
                    int digit = num % 10;
                    sumOfDigits += digit;
                    if (digit % 2 != 0)
                    {
                        containsOddDigit = true;
                    }

                    num /= 10;
                }

                if (sumOfDigits % 8 == 0)
                {
                    divisibleByEigth = true;
                }

                if (divisibleByEigth && containsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
