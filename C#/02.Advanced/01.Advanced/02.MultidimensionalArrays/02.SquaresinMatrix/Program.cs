using System;
using System.Linq;

namespace _02.SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int squaresCount = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1] &&
                        matrix[r, c] == matrix[r + 1, c] &&
                        matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}
