using System;
using System.Linq;

namespace StackEx
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArr = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArr[0] == "Push")
                {
                    int[] elements = commandArr.Skip(1).Select(int.Parse).ToArray();
                    myStack.Push(elements);
                }
                else if (commandArr[0] == "Pop")
                {
                    myStack.Pop();
                }

                command = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
