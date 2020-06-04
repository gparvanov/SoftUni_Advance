using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sum = 0;

            int[,] topMatrix = new int[2, 2];            

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (tempSum > sum)
                    {
                        topMatrix[0, 0] = matrix[row, col];
                        topMatrix[0, 1] = matrix[row, col + 1];
                        topMatrix[1, 0] = matrix[row + 1, col];
                        topMatrix[1, 1] = matrix[row + 1, col + 1];
                        sum = tempSum;
                    }
                }
            }
            for (int row = 0; row < topMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < topMatrix.GetLength(1); col++)
                {
                    Console.Write($"{topMatrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}