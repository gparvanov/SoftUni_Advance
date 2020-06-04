using System;
using System.Collections.Generic;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Queue<string> directions = new Queue<string>(Console.ReadLine().Split());

            char[,] matrix = new char[size,size];
            int startRow = 0;
            int startCol = 0;
            int exitRow = 0;
            int exitCol = 0;
            int totalCoals = 0;
            int foundCoals = 0;
            for (int row = 0; row < size; row++)
            {
                char[] colElements = Console.ReadLine().Replace(" ","").ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = colElements[col];
                    if (colElements[col] == 's')
                    {
                        startCol = col;
                        startRow = row;
                    }
                    else if (colElements[col] == 'c') totalCoals++;
                }               
            }
            int currentRow = startRow;
            int currentCol = startCol;
            while(directions.Count != 0)
            {
                string currentDirection = directions.Dequeue();
                bool moved = true;
                if(currentDirection == "up")
                {
                    if (currentRow - 1 >=0) currentRow--;
                    else moved = false;
                }
                else if (currentDirection == "down")
                {
                    if (currentRow + 1 < size) currentRow++;
                    else moved = false;
                }
                else if ( currentDirection == "left")
                {
                    if (currentCol -1 >=0 ) currentCol--;
                    else moved = false;
                }
                else if ( currentDirection == "right")
                {
                    if (currentCol + 1 < size) currentCol++;
                    else moved = false;
                }
                if (moved)
                {
                    char currentChar = matrix[currentRow, currentCol];
                    if(currentChar == 'e')
                    {
                        exitRow = currentRow;
                        exitCol = currentCol;
                        Console.WriteLine($"Game over! ({exitRow}, {exitCol})");
                        return;
                    }
                    else if (currentChar == 'c')
                    {
                        foundCoals++;
                        matrix[currentRow, currentCol] = '*';
                        exitRow = currentRow;
                        exitCol = currentCol;
                        if (foundCoals == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({exitRow}, {exitCol})");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"{totalCoals - foundCoals} coals left. ({currentRow}, {currentCol})");
        }
    }
}