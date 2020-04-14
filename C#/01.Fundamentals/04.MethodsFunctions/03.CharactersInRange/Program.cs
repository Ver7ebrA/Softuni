using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            PrintCharacters(input1, input2);
        }

        static void PrintCharacters(char a, char b)
        {
            int aASCII = (int)a;
            int bASCII = (int)b;

            if (aASCII < bASCII)
            {
                for (int i = aASCII + 1; i < bASCII; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else if (bASCII < aASCII)
            {
                for (int i = bASCII + 1; i < aASCII; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
    }
}
