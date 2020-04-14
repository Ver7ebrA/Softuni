using System;

namespace _06.MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string str)
        {
            for (int i = 1; i <= str.Length; i++)
            {
                if (str.Length % 2 != 0)
                {
                    if (i == str.Length / 2)
                    {
                        Console.WriteLine(str[i]);
                    }
                }
                else
                {
                    if (i == str.Length / 2)
                    {
                        Console.Write(str[i - 1]);
                        Console.Write(str[i]);
                    }
                }
            }
        }
    }
}
