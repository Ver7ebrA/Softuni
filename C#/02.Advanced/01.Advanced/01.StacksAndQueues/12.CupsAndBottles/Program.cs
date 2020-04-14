using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int wastedWater = 0;

            while (true)
            {
                int nextCup = cups.Peek();
                int nextBottle = bottles.Peek();

                if (nextCup <= nextBottle)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    wastedWater += nextBottle - nextCup;
                }
                else if (nextBottle < nextCup)
                {
                    while (0 < nextCup)
                    {
                        nextBottle = bottles.Pop();
                        nextCup -= nextBottle;
                    }

                    cups.Dequeue();
                    wastedWater += Math.Abs(nextCup);
                }

                if (!bottles.Any())
                {
                    Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }

                if (!cups.Any())
                {
                    Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
            }
        }
    }
}
