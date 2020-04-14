using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonymn = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonymn);
                }
                else
                {
                    words[word].Add(synonymn);
                }
            }

            foreach (var word in words)
            {
                Console.Write($"{word.Key} - {String.Join(", ", word.Value)}");
                Console.WriteLine();
            }
        }
    }
}
