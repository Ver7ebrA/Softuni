using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resourcesMined = new Dictionary<string, int>();

            while (input != "stop")
            {
                string resource = input;
                int resourceQuantity = int.Parse(Console.ReadLine());

                if (resourcesMined.ContainsKey(resource))
                {
                    resourcesMined[resource] += resourceQuantity;
                }
                else
                {
                    resourcesMined.Add(resource, resourceQuantity);
                }

                input = Console.ReadLine();
            }

            foreach (var item in resourcesMined)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
