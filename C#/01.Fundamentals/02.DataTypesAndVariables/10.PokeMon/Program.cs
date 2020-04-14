using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int pokes = 0;
            double halfPower = 0.5 * power;

            while (distance <= power)
            {
                power -= distance;
                pokes++;

                if (power == halfPower)
                {
                    if (exhaustion != 0)
                    {
                        power = power / exhaustion;
                    }
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(pokes);
        }
    }
}
