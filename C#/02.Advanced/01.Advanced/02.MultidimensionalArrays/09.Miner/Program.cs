using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int coalsCount = 0;
            int minerCurrentRow = 0;
            int minerCurrentCol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = elements[col];

                    if (field[row, col] == 'c')
                    {
                        coalsCount++;
                    }
                    else if (field[row, col] == 's')
                    {
                        minerCurrentRow = row;
                        minerCurrentCol = col;
                    }
                }
            }

            bool gameOver = false;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up" &&  0 <= minerCurrentRow - 1)
                {
                    minerCurrentRow -= 1;
                }
                else if (commands[i] == "down" && minerCurrentRow + 1 < field.GetLength(0))
                {
                    minerCurrentRow += 1;
                }
                else if (commands[i] == "left" && 0 <= minerCurrentCol - 1)
                {
                    minerCurrentCol -= 1;
                }
                else if (commands[i] == "right" && minerCurrentCol + 1 < field.GetLength(1))
                {
                    minerCurrentCol += 1;
                }

                if (field[minerCurrentRow, minerCurrentCol] == 'c')
                {
                    coalsCount--;
                    field[minerCurrentRow, minerCurrentCol] = '*';

                    if (coalsCount == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerCurrentRow}, {minerCurrentCol})");
                        break;
                    }
                }
                else if (field[minerCurrentRow, minerCurrentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerCurrentRow}, {minerCurrentCol})");
                    gameOver = true;
                    break;
                }
            }

            if (!gameOver && coalsCount != 0)
            {
                Console.WriteLine($"{coalsCount} coals left. ({minerCurrentRow}, {minerCurrentCol})");
            }
        }
    }
}
