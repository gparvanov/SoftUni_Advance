using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[row] = colElements;
            }

            for (int row = 0; row < rows-1; row++)
            {
                if(matrix[row].Length == matrix[row+1].Length)
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;                        
                    }
                    for (int j = 0; j < matrix[row+1].Length; j++)
                    {
                        matrix[row + 1][j] /= 2.0;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                long value = long.Parse(commandParts[3]);
                if(commandParts[0] == "Add")
                {
                    if(row >=0 && row < rows && col>=0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if ( commandParts[0] == "Subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(Environment.NewLine,matrix.Select( r => String.Join(" ",r))));
        }
    }
}