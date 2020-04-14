using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] initialLadyBugIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[size];

            foreach (int index in initialLadyBugIndexes)
            {
                if (index < 0 || index > size - 1)
                {
                    continue;
                }

                field[index] = 1;
            }

            string command = null;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(" ");
                int ladyBugIndex = int.Parse(tokens[0]);
                string position = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= size || field[ladyBugIndex] != 1)
                {
                    continue;
                }

                if (position == "rigth")
                {
                    field[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex + flyLength;

                    while (newIndex < size)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex += flyLength;
                            continue;
                        }

                        field[newIndex] = 1;
                        break;
                    }
                }
                else if (position == "left")
                {
                    field[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex - flyLength;

                    while (newIndex >= 0)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex -= flyLength;
                            continue;
                        }

                        field[newIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
