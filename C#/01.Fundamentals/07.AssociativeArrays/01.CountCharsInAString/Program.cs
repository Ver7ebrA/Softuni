using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().Trim();
            string[] textArr = text.Split(" ");
            text = string.Empty;
            foreach (var word in textArr)
            {
                text += word;
            }

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (charCounts.ContainsKey(text[i]) == false)
                {
                    charCounts.Add(text[i], 1);
                }
                else
                {
                    charCounts[text[i]]++;
                }
            }

            foreach (var item in charCounts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
