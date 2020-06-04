using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[row, col] = 1;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row >= 1 && col > 0)
                    {
                        matrix[row, col] = matrix[row - 1, col] + matrix[row - 1, col - 1];
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(matrix[row,col] !=0 ) Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}