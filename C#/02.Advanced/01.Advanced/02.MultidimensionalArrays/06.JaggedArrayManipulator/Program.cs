using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] rowArr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArr[row] = rowArr;
            }

            for (int r = 0; r < jaggedArr.Length - 1; r++)
            {
                if (jaggedArr[r].Length == jaggedArr[r + 1].Length)
                {
                    for (int i = 0; i < jaggedArr[r].Length; i++)
                    {
                        jaggedArr[r][i] *= 2;
                        jaggedArr[r + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArr[r].Length; i++)
                    {
                        jaggedArr[r][i] /= 2;
                    }

                    for (int i = 0; i < jaggedArr[r + 1].Length; i++)
                    {
                        jaggedArr[r + 1][i] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArr[0];
                int commandRow = int.Parse(commandArr[1]);
                int commandCol = int.Parse(commandArr[2]);
                double commandValue = double.Parse(commandArr[3]);

                if (0 <= commandRow && commandRow < jaggedArr.Length &&
                    0 <= commandCol && commandCol < jaggedArr[commandRow].Length)
                {
                    if (command == "Add")
                    {
                        jaggedArr[commandRow][commandCol] += commandValue;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArr[commandRow][commandCol] -= commandValue;
                    }
                }

                input = Console.ReadLine();
            }

            for (int j = 0; j < jaggedArr.Length; j++)
            {
                Console.WriteLine(String.Join(" ", jaggedArr[j]));
            }
        }
    }
}
