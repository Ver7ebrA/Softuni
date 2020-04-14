using System;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();
            Random index = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int j = index.Next(words.Length);
                string wordOnj = words[j];
                words[j] = words[i];
                words[i] = wordOnj;
            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
