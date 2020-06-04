using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int mainDiagonal = 0;
            int reversedDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                mainDiagonal += matrix[row, row];
            }
            int collumn = 0;
            for (int row = matrix.GetLength(0) -1 ; row >=0; row--)
            {                
                reversedDiagonal += matrix[row, collumn];
                collumn++;
            }            
            Console.WriteLine(Math.Abs(mainDiagonal-reversedDiagonal));
        }
    }
}