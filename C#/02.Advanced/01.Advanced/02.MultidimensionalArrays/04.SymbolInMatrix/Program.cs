using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string symbol = Console.ReadLine();
            int symbolRowIndex = 0;
            int symbolColIndex = 0;
            bool symbolOccur = false;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c].ToString() == symbol)
                    {
                        symbolRowIndex = r;
                        symbolColIndex = c;
                        symbolOccur = true;
                    }
                }

                if (symbolOccur)
                {
                    break;
                }
            }

            if (symbolOccur)
            {
                Console.WriteLine($"({symbolRowIndex}, {symbolColIndex})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
