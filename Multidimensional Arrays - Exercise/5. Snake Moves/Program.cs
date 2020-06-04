using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            int rows = sizes[0];
            int cols = sizes[1];

            char[,] matrix = new char[rows, cols];

            string leftChars = snake;
            int currentCol = 0;
            for (int row = 0; row < rows; row++)
            {
                bool odd = row % 2 == 1;
                bool even = row % 2 == 0;
                for (int col = 0; col < cols; col++)
                {
                    char currentChar = ' ';
                    if (leftChars.Length > 0)
                    {
                        currentChar = char.Parse(leftChars.Substring(0, 1));
                        leftChars = leftChars.Substring(1, leftChars.Length -1);
                    }
                    else
                    {
                        leftChars = snake;
                        currentChar = char.Parse(leftChars.Substring(0, 1));
                        leftChars = leftChars.Substring(1, leftChars.Length -1 );
                    }
                    matrix[row, currentCol] = currentChar;
                    if (even && currentCol < cols -1) currentCol++;
                    else if  (odd && currentCol >0) currentCol--;
                }               
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}