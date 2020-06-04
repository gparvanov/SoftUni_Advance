using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int aliveCells = 0;
            int sum = 0;
            Queue<string> bombs = new Queue<string>(Console.ReadLine().Split());

            while (bombs.Count != 0)
            {
                int[] bombsCoordinates = bombs.Dequeue().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bombRow = bombsCoordinates[0];
                int bombCol = bombsCoordinates[1];
                DetonateBomb(matrix, bombRow, bombCol);
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        private static void DetonateBomb(int[,] matrix, int bombRow, int bombCol)
        {
            int bombPower = matrix[bombRow, bombCol];
            if (matrix[bombRow, bombCol] > 0)
            {
                matrix[bombRow, bombCol] = 0;
                if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0)
                    && bombCol - 1 >= 0 && bombCol - 1 < matrix.GetLength(1)
                    && matrix[bombRow - 1, bombCol - 1] > 0) matrix[bombRow - 1, bombCol - 1] -= bombPower;
                if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0)
                    && matrix[bombRow - 1, bombCol] > 0) matrix[bombRow - 1, bombCol] -= bombPower;
                if (bombRow - 1 >= 0 && bombRow - 1 < matrix.GetLength(0)
                    && bombCol + 1 >= 0 && bombCol + 1 < matrix.GetLength(1)
                    && matrix[bombRow - 1, bombCol + 1] > 0) matrix[bombRow - 1, bombCol + 1] -= bombPower;
                if (bombCol - 1 >= 0 && matrix[bombRow, bombCol - 1] > 0) matrix[bombRow, bombCol - 1] -= bombPower;
                if (bombCol + 1 < matrix.GetLength(1) && matrix[bombRow, bombCol + 1] > 0) matrix[bombRow, bombCol + 1] -= bombPower;
                if (bombRow + 1 < matrix.GetLength(0)
                    && bombCol - 1 >= 0 && bombCol - 1 < matrix.GetLength(1)
                    && matrix[bombRow + 1, bombCol - 1] > 0) matrix[bombRow + 1, bombCol - 1] -= bombPower;
                if (bombRow + 1 < matrix.GetLength(0) && matrix[bombRow + 1, bombCol] > 0) matrix[bombRow + 1, bombCol] -= bombPower;
                if (bombRow + 1 < matrix.GetLength(0)
                    && bombCol + 1 < matrix.GetLength(1) && matrix[bombRow + 1, bombCol + 1] > 0) matrix[bombRow + 1, bombCol + 1] -= bombPower;
            }
        }
    }
}