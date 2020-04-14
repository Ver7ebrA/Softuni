using System;
using System.Linq;

namespace _03.maximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
           
            int maxSum = 0;
            int squareStartRow = 0;
            int squareStartCol = 0;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int sum = 0;

                    for (int r1 = r; r1 < r + 3; r1++)
                    {
                        for (int c1 = c; c1 < c + 3; c1++)
                        {
                            sum += matrix[r1, c1];
                        }
                    }

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        squareStartRow = r;
                        squareStartCol = c;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = squareStartRow; i < squareStartRow + 3; i++)
            {
                for (int j = squareStartCol; j < squareStartCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
