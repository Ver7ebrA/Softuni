using System;

namespace _01.BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int buiscitsPerWorkerPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int CompetingFactoryBuiscits = int.Parse(Console.ReadLine());
            double TotalBuiscits = 0.00;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    TotalBuiscits += Math.Floor(0.75 * buiscitsPerWorkerPerDay * workers);
                }
                else
                {
                    TotalBuiscits += buiscitsPerWorkerPerDay * workers;
                }
            }

            Console.WriteLine($"You have produced {TotalBuiscits} biscuits for the past month.");

            if (TotalBuiscits > CompetingFactoryBuiscits)
            {
                double percentage = ((TotalBuiscits - CompetingFactoryBuiscits) / CompetingFactoryBuiscits) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                double percentage = ((CompetingFactoryBuiscits - TotalBuiscits) / CompetingFactoryBuiscits) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
