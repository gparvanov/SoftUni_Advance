using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _2._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialString = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < size; row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];
                    if (matrix[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentRow--;
                    if (currentRow < 0)
                    {
                        if (initialString.Length > 1) initialString = initialString.Substring(0, initialString.Length - 1);
                        else initialString = "";
                        currentRow++;
                    }
                    else 
                    {
                        if(matrix[currentRow, currentCol] != '-' ) initialString += matrix[currentRow, currentCol];
                    }
                    matrix[currentRow, currentCol] = 'P';
                }
                else if (command == "down")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentRow++;
                    if (currentRow >= size)
                    {
                        if (initialString.Length > 1) initialString = initialString.Substring(0, initialString.Length - 1);
                        else initialString = "";
                        currentRow--;
                    }
                    else
                    {
                        if (matrix[currentRow, currentCol] != '-') initialString += matrix[currentRow, currentCol];
                    }
                    matrix[currentRow, currentCol] = 'P';
                }
                else if (command == "left")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentCol--;
                    if (currentCol < 0)
                    {
                        if (initialString.Length > 1) initialString = initialString.Substring(0, initialString.Length - 1);
                        else initialString = "";
                        currentCol++;
                    }
                    else 
                    {
                        if (matrix[currentRow, currentCol] != '-') initialString += matrix[currentRow, currentCol];
                    }
                    matrix[currentRow, currentCol] = 'P';
                }
                else if (command == "right")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentCol++;
                    if (currentCol >= size)
                    {
                        if (initialString.Length > 1) initialString = initialString.Substring(0, initialString.Length - 1);
                        else initialString = "";
                        currentCol--;
                    }
                    else 
                    {
                        if (matrix[currentRow, currentCol] != '-') initialString += matrix[currentRow, currentCol];
                    }
                    matrix[currentRow, currentCol] = 'P';
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(initialString);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}