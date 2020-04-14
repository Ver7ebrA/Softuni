using System;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            double highestSnowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality); 
                if (highestSnowballValue < snowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    highestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
