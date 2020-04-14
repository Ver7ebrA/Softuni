using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string[] clothes = input[1].Split("," , StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[colour].ContainsKey(item))
                        {
                            wardrobe[colour][item] = 1;
                        }
                        else
                        {
                            wardrobe[colour][item]++;
                        }

                        
                    }
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[colour].ContainsKey(item))
                        {
                            wardrobe[colour][item] = 1;
                        }
                        else
                        {
                            wardrobe[colour][item]++;
                        }
                    }
                }               
            }

            string[] clothingToFind = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colourOfClothing = clothingToFind[0];
            string typeOfClothing = clothingToFind[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item1 in item.Value)
                {
                    if (item.Key == colourOfClothing && item1.Key == typeOfClothing)
                    {
                        Console.WriteLine($"* {item1.Key} - {item1.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item1.Key} - {item1.Value}");
                    }
                }
            }
        }
    }
}
