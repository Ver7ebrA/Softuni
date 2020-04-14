using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());

            int currentRackCapacity = 0;
            int racksCount = 1;

            while (clothes.Any())
            {
                if (currentRackCapacity + clothes.Peek() <= rackCapacity)
                {
                    currentRackCapacity += clothes.Pop();
                }
                else
                {
                    currentRackCapacity = clothes.Pop();
                    racksCount++;
                }
            }
        

            Console.WriteLine(racksCount);
        }
    }
}
