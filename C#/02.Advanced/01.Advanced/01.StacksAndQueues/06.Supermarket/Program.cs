using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> clients = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    clients.Enqueue(input);
                }
                else
                {
                    while (clients.Any())
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
