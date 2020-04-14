using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int intelligenceValue = int.Parse(Console.ReadLine());

            int bulletsUsed = 0;
            int barrel = barrelSize;

            while (true)
            {
                int bulletSize = bullets.Pop();
                int lockSize = locks.Peek();
                bulletsUsed++;

                if (bulletSize <= lockSize)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                barrel--;

                if (barrel == 0 && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");

                    barrel = barrelSize;
                }


                if (!bullets.Any() && locks.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                if (!locks.Any())
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - (bulletsUsed * bulletPrice)}");
                    break;
                }
            }
        }
    }
}
