using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Re_Volt
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            int playerRow = 0;
            int playerCol = 0;

            bool playerWon = false;

            for (int row = 0; row < matrixSize; row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                    
                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col];

                    if (colElements[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            int nextPlayerRow = playerRow;
            int nextPlayerCol = playerCol;

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();              

                if (command == "up")
                {
                    nextPlayerRow = playerRow - 1;
                    if (nextPlayerRow < 0)
                    {
                        nextPlayerRow = matrix.GetLength(0) - 1;
                    }

                }
                else if (command == "down")
                {
                    nextPlayerRow = playerRow + 1;
                    if (matrix.GetLength(0) - 1 < nextPlayerRow)
                    {
                        nextPlayerRow = 0;
                    }
                }
                else if (command == "left")
                {
                    nextPlayerCol = playerCol - 1;
                    if (nextPlayerCol < 0)
                    {
                        nextPlayerCol = matrix.GetLength(1) - 1;
                    }

                }
                else if (command == "right")
                {
                    nextPlayerCol = playerCol + 1;
                    if (matrix.GetLength(1) - 1 < nextPlayerCol)
                    {
                        nextPlayerCol = 0;
                    }
                }

                if (matrix[nextPlayerRow, nextPlayerCol] == 'B')
                {
                    if (command == "up")
                    {
                        nextPlayerRow--;
                    }
                    else if (command == "down")
                    {
                        nextPlayerRow++;
                    }
                    else if (command == "left")
                    {
                        nextPlayerCol--;

                    }
                    else if (command == "right")
                    {
                        nextPlayerCol++;

                    }
                }
                else if (matrix[nextPlayerRow, nextPlayerCol] == 'T')
                {
                    if (command == "up")
                    {
                        nextPlayerRow++;
                    }
                    else if (command == "down")
                    {
                        nextPlayerRow--;
                    }
                    else if (command == "left")
                    {
                        nextPlayerCol++;
                    }
                    else if (command == "right")
                    {
                        nextPlayerCol--;
                    }
                }

                if (nextPlayerRow < 0)
                {
                    nextPlayerRow = matrix.GetLength(0) - 1;
                }

                if (matrix.GetLength(0) - 1 < nextPlayerRow)
                {
                    nextPlayerRow = 0;
                }

                if (nextPlayerCol < 0)
                {
                    nextPlayerCol = matrix.GetLength(1) - 1;
                }

                if (matrix.GetLength(1) - 1 < nextPlayerCol)
                {
                    nextPlayerCol = 0;
                }

                if (matrix[nextPlayerRow, nextPlayerCol] == 'F')
                {
                    playerWon = true;
                }

                matrix[playerRow, playerCol] = '-';
                matrix[nextPlayerRow, nextPlayerCol] = 'f';
                playerRow = nextPlayerRow;
                playerCol = nextPlayerCol;

                if (playerWon)
                {
                    break;
                }
            }

            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}
