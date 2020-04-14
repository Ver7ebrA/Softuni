using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int temp = 0;

            foreach (var ch in bigNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * smallNumber + temp;

                int resultDigit = result % 10;
                temp = result / 10;

                sb.Insert(0, resultDigit);
            }

            if (0 < temp)
            {
                sb.Insert(0, temp);
            }

            string finalnumber = sb.ToString().TrimStart('0');

            if (finalnumber.Length == 0)
            {
                finalnumber = "0";
            }
            Console.WriteLine(finalnumber);
        }
    }
}
