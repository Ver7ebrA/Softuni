using System;
using System.Linq;

namespace _04.MatrixShufgling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArr.Count() != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (commandArr[0] != "swap")
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        int firstElementRow = int.Parse(commandArr[1]);
                        int firstElementCol = int.Parse(commandArr[2]);
                        int secondElementRow = int.Parse(commandArr[3]);
                        int secondElementCol = int.Parse(commandArr[4]);

                        if (firstElementRow < 0 || matrix.GetLength(0) < firstElementRow ||
                            firstElementCol < 0 || matrix.GetLength(1) < firstElementCol ||
                            secondElementRow < 0 || matrix.GetLength(0) < secondElementRow ||
                            secondElementCol < 0 || matrix.GetLength(1) < secondElementCol)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string firstElement = matrix[firstElementRow, firstElementCol];
                            string secondElement = matrix[secondElementRow, secondElementCol];
                            matrix[secondElementRow, secondElementCol] = firstElement;
                            matrix[firstElementRow, firstElementCol] = secondElement;

                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write(matrix[r, c] + " ");
                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
