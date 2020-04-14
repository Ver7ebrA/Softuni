using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = text => Console.WriteLine(text);

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
