using System;
using System.Linq;

namespace _05.SquareWithMazimumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int maxSum = int.MinValue;
            int squareStarRow = int.MaxValue;
            int squareStartCol = int.MaxValue;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1]
                        + matrix[r + 1, c] + matrix[r + 1, c + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        squareStarRow = r;
                        squareStartCol = c;
                    }
                    else if (maxSum == sum && r < squareStarRow && c < squareStartCol)
                    {
                        squareStarRow = r;
                        squareStartCol = c;
                    }
                }
            }

            Console.WriteLine($"{matrix[squareStarRow, squareStartCol]} {matrix[squareStarRow, squareStartCol + 1]}");
            Console.WriteLine($"{matrix[squareStarRow + 1, squareStartCol]} {matrix[squareStarRow + 1, squareStartCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
