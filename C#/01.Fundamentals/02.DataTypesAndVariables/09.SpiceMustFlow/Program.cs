using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());
            int days = 0;
            int spiceTotal = 0;

            if (spice < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(spiceTotal);
            }
            else
            {
                while (100 <= spice)
                {
                    spiceTotal += spice - 26;
                    days++;
                    spice -= 10;
                }

                spiceTotal -= 26;

                Console.WriteLine(days);
                Console.WriteLine(spiceTotal);
            }
        }
    }
}
