using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < size; row++)
            {
                char[] colParts = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    if(colParts[col] == 'f')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    matrix[row, col] = colParts[col];
                }
            }
            int currentRow = startRow;
            int currentCol = startCol;
            bool won = false;
            for (int i = 0; i < commandsCount; i++)
            {
                string direction = Console.ReadLine();
                if (direction == "up")
                {
                    if (currentRow - 1 < 0)
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentRow = size -1;
                        if(matrix[currentRow,currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if(currentRow -1 < 0)
                            {
                                currentRow = size - 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            if (currentRow + 1 >= size)
                            {
                                currentRow = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentRow -= 1;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentRow - 1 < 0)
                            {
                                currentRow = size -1 ;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            currentRow += 1;
                            matrix[currentRow, currentCol] = 'f';
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                }
                else if (direction == "down")
                {
                    if (currentRow + 1 >= size)
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentRow = 0;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentRow + 1 >= size)
                            {
                                currentRow = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            if (currentRow - 1 < 0)
                            {
                                currentRow = size -1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentRow += 1;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentRow + 1 >= size)
                            {
                                currentRow = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentRow += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            currentRow -= 1;
                            matrix[currentRow, currentCol] = 'f';
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                }
                else if (direction == "left")
                {
                    if (currentCol -1 < 0)
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentCol = size -1 ;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentCol - 1 < 0)
                            {
                                currentCol = size -1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            if (currentCol + 1 >= size)
                            {
                                currentCol = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }                        
                        else matrix[currentRow, currentCol] = 'f';
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentCol -= 1;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentCol - 1 < 0)
                            {
                                currentCol = size -1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            currentCol += 1;
                            matrix[currentRow, currentCol] = 'f';
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                }
                else if (direction == "right")
                {
                    if (currentCol + 1 >= size)
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentCol = 0;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentCol + 1 >= size)
                            {
                                currentCol = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            if (currentCol - 1 < 0)
                            {
                                currentCol = size -1 ;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol -= 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = '-';
                        currentCol += 1;
                        if (matrix[currentRow, currentCol] == 'F')
                        {
                            won = true;
                            matrix[currentRow, currentCol] = 'f';
                            break;
                        }
                        else if (matrix[currentRow, currentCol] == 'B')
                        {
                            if (currentCol + 1 >= size)
                            {
                                currentCol = 0;
                                matrix[currentRow, currentCol] = 'f';
                            }
                            else
                            {
                                currentCol += 1;
                                matrix[currentRow, currentCol] = 'f';
                            }
                        }
                        else if (matrix[currentRow, currentCol] == 'T')
                        {
                            currentCol -= 1;
                            matrix[currentRow, currentCol] = 'f';
                        }
                        else matrix[currentRow, currentCol] = 'f';
                    }
                }                
                if (won) break;
            }
            if (won) Console.WriteLine("Player won!");
            else Console.WriteLine("Player lost!");
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