using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (char ch in text)
            {
                Console.Write((char)(ch + 3));
            }
        }
    }
}
