using System;
using System.Collections.Generic;


namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < size; row++)
            {
                char[] colEleents = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colEleents[col];
                    if (matrix[row, col] == 'S')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            bool snakeOut = false;
            int foodEaten = 0;
            while (!snakeOut)
            {
                if(command == "up")
                {
                    matrix[currentRow, currentCol] = '.';
                    currentRow--;
                    if (currentRow < 0)
                    {
                        snakeOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentRow, currentCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else if (matrix[currentRow, currentCol] == '-') matrix[currentRow, currentCol] = 'S';
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            matrix[currentRow, currentCol] = '.';
                            for (int row = 0; row < size; row++)
                            {
                                for (int col = 0; col < size; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[currentRow, currentCol] = 'S';
                                    }
                                }
                            }
                        }
                    }
                }
                else if ( command == "down")
                {
                    matrix[currentRow, currentCol] = '.';
                    currentRow++;
                    if (currentRow >=size)
                    {
                        snakeOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentRow, currentCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else if (matrix[currentRow, currentCol] == '-') matrix[currentRow, currentCol] = 'S';
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            matrix[currentRow, currentCol] = '.';
                            for (int row = 0; row < size; row++)
                            {
                                for (int col = 0; col < size; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[currentRow, currentCol] = 'S';
                                    }
                                }
                            }
                        }
                    }
                }
                else if ( command == "left")
                {
                    matrix[currentRow, currentCol] = '.';
                    currentCol--;
                    if (currentCol <0)
                    {
                        snakeOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentRow, currentCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else if (matrix[currentRow, currentCol] == '-') matrix[currentRow, currentCol] = 'S';
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            matrix[currentRow, currentCol] = '.';
                            for (int row = 0; row < size; row++)
                            {
                                for (int col = 0; col < size; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[currentRow, currentCol] = 'S';
                                    }
                                }
                            }
                        }
                    }
                }
                else if ( command == "right")
                {
                    matrix[currentRow, currentCol] = '.';
                    currentCol++;
                    if (currentCol >=size)
                    {
                        snakeOut = true;
                        break;
                    }
                    else
                    {
                        if (matrix[currentRow, currentCol] == '*')
                        {
                            foodEaten++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else if (matrix[currentRow, currentCol] == '-') matrix[currentRow, currentCol] = 'S';
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            matrix[currentRow, currentCol] = '.';
                            for (int row = 0; row < size; row++)
                            {
                                for (int col = 0; col < size; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[currentRow, currentCol] = 'S';
                                    }
                                }
                            }
                        }
                    }
                }
                if (foodEaten >= 10) break;                
                command = Console.ReadLine();
            }            
            if (snakeOut) Console.WriteLine("Game over!");
            if (foodEaten >= 10) Console.WriteLine("You won! You fed the snake.");
            Console.WriteLine($"Food eaten: {foodEaten}");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}