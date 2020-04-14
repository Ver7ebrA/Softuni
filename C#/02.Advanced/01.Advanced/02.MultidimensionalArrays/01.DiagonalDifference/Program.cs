using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];                }
                    
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                primaryDiagonalSum += matrix[r, r];
                secondaryDiagonalSum += matrix[(matrix.GetLength(0) - 1) - r, r];
            }

            Console.WriteLine($"{Math.Abs(primaryDiagonalSum - secondaryDiagonalSum)}");
        }
    }
}
