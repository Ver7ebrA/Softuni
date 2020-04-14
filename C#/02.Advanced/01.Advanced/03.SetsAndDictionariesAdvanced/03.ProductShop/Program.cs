using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }

                string[] inputArr = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = inputArr[0];
                string product = inputArr[1];
                double price = double.Parse(inputArr[2]);

                if (shops.ContainsKey(shop))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var kvp1 in shops[kvp.Key])
                {
                    Console.WriteLine($"Product: {kvp1.Key}, Price: {kvp1.Value}");
                }
            }
        }
    }
}
