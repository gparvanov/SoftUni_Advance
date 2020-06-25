using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int goodKids = 0;
            int currentRow = 0;
            int currentCol = 0;
            int foundGoodKids = 0;
            for (int row = 0; row < size; row++)
            {
                char[] colElements = Console.ReadLine().Replace(" ","").ToCharArray();
                for (int col = 0; col < size; col++)
                {                    
                    matrix[row, col] = colElements[col];
                    if (matrix[row, col] == 'V') goodKids++;
                    else if ( matrix[row,col] == 'S')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            string direction = Console.ReadLine();
            while(direction != "Christmas morning")
            {
                if(direction == "up")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentRow -= 1;
                    if (matrix[currentRow, currentCol] == 'V')
                    {
                        if (presents > 0)
                        {
                            presents--;
                            foundGoodKids++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else break;
                    }
                    else if (matrix[currentRow,currentCol] == 'X') matrix[currentRow, currentCol] = 'S';
                    else if (matrix[currentRow,currentCol] == 'C')
                    {
                        if(matrix[currentRow-1,currentCol] == 'X' || matrix[currentRow - 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow -1 , currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow - 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow + 1, currentCol] == 'X' || matrix[currentRow + 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow + 1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow + 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol-1] == 'X' || matrix[currentRow, currentCol-1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol -1 ] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol -1] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol +1 ] == 'X' || matrix[currentRow, currentCol+1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol +1 ] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol+1] = '-';
                            }
                            else break;
                        }
                        matrix[currentRow, currentCol] = 'S';
                    }
                    else matrix[currentRow, currentCol] = 'S';
                }
                else if ( direction == "down")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentRow += 1;
                    if (matrix[currentRow, currentCol] == 'V')
                    {
                        if (presents > 0)
                        {
                            presents--;
                            foundGoodKids++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else break;
                    }
                    else if (matrix[currentRow, currentCol] == 'X') matrix[currentRow, currentCol] = 'S';
                    else if (matrix[currentRow, currentCol] == 'C')
                    {
                        if (matrix[currentRow - 1, currentCol] == 'X' || matrix[currentRow - 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow - 1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow - 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow + 1, currentCol] == 'X' || matrix[currentRow + 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow+1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow + 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol - 1] == 'X' || matrix[currentRow, currentCol - 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol - 1] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol - 1] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol + 1] == 'X' || matrix[currentRow, currentCol + 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol + 1] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol + 1] = '-';
                            }
                            else break;
                        }
                        matrix[currentRow, currentCol] = 'S';
                    }
                    else matrix[currentRow, currentCol] = 'S';
                }
                else if (direction == "left")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentCol -= 1;
                    if (matrix[currentRow, currentCol] == 'V')
                    {
                        if (presents > 0)
                        {
                            presents--;
                            foundGoodKids++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else break;
                    }
                    else if (matrix[currentRow, currentCol] == 'X') matrix[currentRow, currentCol] = 'S';
                    else if (matrix[currentRow, currentCol] == 'C')
                    {
                        if (matrix[currentRow - 1, currentCol] == 'X' || matrix[currentRow - 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if(matrix[currentRow - 1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow - 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow + 1, currentCol] == 'X' || matrix[currentRow + 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow + 1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow + 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol - 1] == 'X' || matrix[currentRow, currentCol - 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol - 1 ] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol - 1] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol + 1] == 'X' || matrix[currentRow, currentCol + 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol+1] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol + 1] = '-';
                            }
                            else break;
                        }
                        matrix[currentRow, currentCol] = 'S';
                    }
                    else matrix[currentRow, currentCol] = 'S';
                }
                else if ( direction == "right")
                {
                    matrix[currentRow, currentCol] = '-';
                    currentCol += 1;
                    if (matrix[currentRow, currentCol] == 'V')
                    {
                        if (presents > 0)
                        {
                            presents--;
                            foundGoodKids++;
                            matrix[currentRow, currentCol] = 'S';
                        }
                        else break;
                    }
                    else if (matrix[currentRow, currentCol] == 'X') matrix[currentRow, currentCol] = 'S';
                    else if (matrix[currentRow, currentCol] == 'C')
                    {
                        if (matrix[currentRow - 1, currentCol] == 'X' || matrix[currentRow - 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow -1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow - 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow + 1, currentCol] == 'X' || matrix[currentRow + 1, currentCol] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow +1, currentCol] == 'V') foundGoodKids++;
                                matrix[currentRow + 1, currentCol] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol - 1] == 'X' || matrix[currentRow, currentCol - 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol - 1] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol - 1] = '-';
                            }
                            else break;
                        }
                        if (matrix[currentRow, currentCol + 1] == 'X' || matrix[currentRow, currentCol + 1] == 'V')
                        {
                            if (presents > 0)
                            {
                                presents--;
                                if (matrix[currentRow, currentCol + 1] == 'V') foundGoodKids++;
                                matrix[currentRow, currentCol + 1] = '-';
                            }
                            else break;
                        }
                        matrix[currentRow, currentCol] = 'S';
                    }
                    else matrix[currentRow, currentCol] = 'S';
                }
                if (presents <= 0) break;
                direction = Console.ReadLine();
            }
            if (presents <= 0) Console.WriteLine("Santa ran out of presents!");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
            if (foundGoodKids == goodKids) Console.WriteLine($"Good job, Santa! {goodKids} happy nice kid/s.");
            else Console.WriteLine($"No presents for {goodKids - foundGoodKids} nice kid/s.");
        }
    }
}