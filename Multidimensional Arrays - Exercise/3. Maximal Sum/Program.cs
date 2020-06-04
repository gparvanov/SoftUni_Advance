using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            if (sizes[0] > 3 && sizes[1] > 3)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = colElements[col];
                    }
                }
                int sum = 0;
                int startRow = 0;
                int startCol = 0;
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        int currentSum = 0;
                        currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                        currentSum += matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                        currentSum += matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (currentSum > sum)
                        {
                            sum = currentSum;
                            startRow = row;
                            startCol = col;
                        }
                    }
                }
                Console.WriteLine($"Sum = {sum}");
                for (int row = startRow; row < startRow+3; row++)
                {
                    for (int col = startCol; col < startCol+3; col++)
                    {
                        Console.Write($"{matrix[row,col]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}