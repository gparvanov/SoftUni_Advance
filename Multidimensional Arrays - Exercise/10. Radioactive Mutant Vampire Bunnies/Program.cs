using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            int currentRow = 0;
            int currentCol = 0;
            Queue<string> bunnies = new Queue<string>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                    if(colElements[col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (colElements[col] == 'B')
                    {
                        bunnies.Enqueue(row + "," + col);
                    }
                }
            }
            Queue<char> directions = new Queue<char>(Console.ReadLine().ToCharArray());
            bool live = true;
            bool playerWin = false; 

            while (directions.Count != 0)
            {
                char goTo = directions.Dequeue();                
                if(goTo == 'U')
                {
                    if (currentRow - 1 >= 0 && matrix[currentRow - 1, currentCol] != 'B')
                    {
                        matrix[currentRow - 1, currentCol] = 'P';
                        matrix[currentRow, currentCol] = '.';
                        currentRow = currentRow - 1;
                    }
                    else if (currentRow - 1 < 0)
                    {
                        matrix[currentRow, currentCol] = '.';
                        playerWin = true;                        
                    }
                    else if (currentRow - 1 >= 0 && matrix[currentRow - 1, currentCol] == 'B')
                    {
                        live = false;
                        currentRow = currentRow - 1;
                    }
                }
                else if (goTo == 'D')
                {
                    if (currentRow + 1 < matrix.GetLength(0) && matrix[currentRow + 1, currentCol] != 'B')
                    {
                        matrix[currentRow + 1, currentCol] = 'P';
                        matrix[currentRow, currentCol] = '.';
                        currentRow = currentRow + 1;
                    }
                    else if (currentRow + 1 >= matrix.GetLength(0))
                    {
                        matrix[currentRow, currentCol] = '.';
                        playerWin = true;                        
                    }
                    else if (currentRow + 1 < matrix.GetLength(0) && matrix[currentRow + 1, currentCol] == 'B')
                    {
                        live = false;
                        currentRow = currentRow + 1;
                    }
                }
                else if (goTo == 'L')
                {
                    if (currentCol - 1 >= 0 && matrix[currentRow, currentCol - 1] != 'B')
                    {
                        matrix[currentRow, currentCol - 1] = 'P';
                        matrix[currentRow, currentCol] = '.';
                        currentCol = currentCol - 1;
                    }
                    else if (currentCol - 1 < 0)
                    {
                        matrix[currentRow, currentCol] = '.';
                        playerWin = true;                        
                    }
                    else if (currentCol - 1 >= 0 && matrix[currentRow, currentCol - 1] == 'B')
                    {
                        live = false;
                        currentCol = currentCol - 1;                        
                    }
                }
                else if (goTo == 'R')
                {
                    if (currentCol + 1 < matrix.GetLength(1) && matrix[currentRow, currentCol + 1] != 'B')
                    {
                        matrix[currentRow, currentCol + 1] = 'P';
                        matrix[currentRow, currentCol] = '.';
                        currentCol = currentCol + 1;
                    }
                    else if (currentCol + 1 >= matrix.GetLength(1))
                    {
                        matrix[currentRow, currentCol] = '.';
                        playerWin = true;                        
                    }
                    else if (currentCol + 1 < matrix.GetLength(1) && matrix[currentRow, currentCol + 1] == 'B')
                    {
                        live = false;
                        currentCol = currentCol + 1;                        
                    }
                }                
                SpawnRabbits(matrix,bunnies,currentRow,currentCol);                
                UpdateRabbits(matrix, bunnies);
                if (playerWin) break;
                bool playerLive = CheckLive(matrix);
                if (!playerLive)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                    return;
                }                
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
            if (live) Console.WriteLine($"won: {currentRow} {currentCol}");
            else Console.WriteLine($"dead: {currentRow} {currentCol}");
        }
        private static void UpdateRabbits(char[,] matrix, Queue<string> bunnies)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 'B')
                    {
                        bunnies.Enqueue(row + "," + col);
                    }
                }
            }
        }
        private static bool CheckLive(char[,] matrix)
        {
            bool live = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {                    
                    if (matrix[row,col] == 'P')
                    {
                        live = true;
                        return live;
                    }
                }
            }
            return live;
        }
        private static void SpawnRabbits(char[,] matrix, Queue<string> bunnies,int currentRow, int currentCol)
        {
            while (bunnies.Count != 0)
            {
                int[] bunnyCoordinates = bunnies.Dequeue().Split(",").Select(int.Parse).ToArray();
                int bunnyRow = bunnyCoordinates[0];
                int bunnyCol = bunnyCoordinates[1];                
                if (bunnyRow - 1 >= 0 ) matrix[bunnyRow - 1, bunnyCol] = 'B';
                if (bunnyCol - 1 >= 0 ) matrix[bunnyRow, bunnyCol - 1] = 'B';
                if (bunnyCol + 1 < matrix.GetLength(1)) matrix[bunnyRow, bunnyCol + 1] = 'B';
                if (bunnyRow + 1 < matrix.GetLength(0)) matrix[bunnyRow + 1, bunnyCol] = 'B';                
            }    
        }
    }
}