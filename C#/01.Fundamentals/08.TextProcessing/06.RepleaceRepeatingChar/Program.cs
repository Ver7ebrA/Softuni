using System;

namespace _06.RepleaceRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char previousChar = text[0];
            Console.Write(previousChar);

            for (int i = 1; i < text.Length; i++)
            {
                if (previousChar != text[i])
                {
                    previousChar = text[i];
                    Console.Write(previousChar);
                }
            }
        }
    }
}
