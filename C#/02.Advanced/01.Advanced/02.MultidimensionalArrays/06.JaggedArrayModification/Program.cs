using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                jaggedArr[r] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int commandRow = int.Parse(commandArr[1]);
                int commandCol = int.Parse(commandArr[2]);
                int commandValue = int.Parse(commandArr[3]);

                if (commandRow < 0 ||jaggedArr.Length < commandRow ||
                    jaggedArr[commandRow].Length < commandCol ||
                    commandCol < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (commandArr[0] == "Add")
                    {
                        jaggedArr[commandRow][commandCol] += commandValue;
                    }
                    else if (commandArr[0] == "Subtract")
                    {
                        jaggedArr[commandRow][commandCol] -= commandValue;
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine(String.Join(" ", jaggedArr[i]));
            }
        }
    }
}
