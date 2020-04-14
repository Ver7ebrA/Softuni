using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int biggestOrder = 0;

            Queue<int> tempQueue = new Queue<int>(orders);

            while (tempQueue.Any())
            {
                int curentOrder = tempQueue.Dequeue();

                if (biggestOrder < curentOrder)
                {
                    biggestOrder = curentOrder;
                }
            }

            Console.WriteLine(biggestOrder);

            while (true)
            {
                int nextOrder = orders.Peek();

                if (nextOrder <= foodQuantity)
                {
                    orders.Dequeue();
                    foodQuantity -= nextOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    break;
                }

                if (!orders.Any())
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
        }
    }
}
