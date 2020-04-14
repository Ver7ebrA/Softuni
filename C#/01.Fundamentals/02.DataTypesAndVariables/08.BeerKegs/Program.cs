using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKegVolume = 0;
            string biggestKeg = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * kegRadius *kegRadius * kegHeight;

                if (biggestKegVolume < kegVolume)
                {
                    biggestKeg = kegModel;
                    biggestKegVolume = kegVolume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
