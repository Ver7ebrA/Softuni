using System;
using System.Linq;

namespace ListyIteratorEx
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new ListyIterator<string>(Console.ReadLine()
                .Split()
                .Skip(1)
                .ToArray());

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (command == "Print")
                {
                    list.Print();
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in list)
                    {
                        Console.Write($"{item} ");
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
