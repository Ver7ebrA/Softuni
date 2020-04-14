using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstname}{delimiter}{secondName}");
        }
    }
}
