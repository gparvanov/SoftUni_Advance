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
            for (int row = 0; row < size; row++)
            {
                char[] colParts = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colParts[col];
                }
            }
            bool won = false;
            for (int i = 0; i < commandsCount; i++)
            {
                string direction = Console.ReadLine();
                won = MovePlayer(matrix, direction);
                if (won) break;
            }
            if (won) Console.WriteLine("Player won!");
            else Console.WriteLine("Player lost!");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static int[] PlayerCoordinates(char[,] matrix)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }
            return coordinates;
        }

        private static bool MovePlayer(char[,] matrix, string direction)
        {
            bool won = false;
            int size = matrix.GetLength(0);
            int[] coordinates = PlayerCoordinates(matrix);
            int row = coordinates[0];
            int col = coordinates[1];
            if (direction == "up")
            {
                matrix[row, col] = '-';
                if (row - 1 < 0) row = size - 1;
                else row -= 1;
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = 'f';
                    return true;
                }
                else if (matrix[row, col] == 'B')
                {
                    if (row - 1 < 0) row = size - 1;
                    else row -= 1;
                    if (matrix[row, col] == 'F')
                    {
                        matrix[row, col] = 'f';
                        return true;
                    }
                    else matrix[row, col] = 'f';
                }
                else if (matrix[row, col] == 'T')
                {
                    if (row + 1 >= size) row = 0;
                    else row += 1;
                    matrix[row, col] = 'f';
                }
                else matrix[row, col] = 'f';
            }
            else if (direction == "down")
            {
                matrix[row, col] = '-';
                if (row + 1 >= size) row = 0;
                else row += 1;
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = 'f';
                    return true;
                }
                else if (matrix[row, col] == 'B')
                {
                    if (row + 1 >= size) row = 0;
                    else row += 1;
                    if (matrix[row, col] == 'F')
                    {
                        matrix[row, col] = 'f';
                        return true;
                    }
                    else matrix[row, col] = 'f';
                }
                else if (matrix[row, col] == 'T')
                {
                    if (row - 1 < 0) row = size - 1;
                    else row -= 1;
                    matrix[row, col] = 'f';
                }
                else matrix[row, col] = 'f';
            }
            else if (direction == "left")
            {
                matrix[row, col] = '-';
                if (col - 1 < 0) col = size -1;
                else col -= 1;
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = 'f';
                    return true;
                }
                else if (matrix[row, col] == 'B')
                {
                    if (col - 1 < 0) col = size - 1;
                    else col -= 1;
                    if (matrix[row, col] == 'F')
                    {
                        matrix[row, col] = 'f';
                        return true;
                    }
                    else matrix[row, col] = 'f';
                }
                else if (matrix[row, col] == 'T')
                {
                    if (col + 1 >= size) col = 0;
                    else col += 1;
                    matrix[row, col] = 'f';
                }
                else matrix[row, col] = 'f';
            }
            else if (direction == "right")
            {
                matrix[row, col] = '-';
                if (col + 1 >= size ) col = 0;
                else col += 1;
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = 'f';
                    return true;
                }
                else if (matrix[row, col] == 'B')
                {
                    if (col + 1 >= size) col = 0;
                    else col += 1;
                    if (matrix[row, col] == 'F')
                    {
                        matrix[row, col] = 'f';
                        return true;
                    }
                    else matrix[row, col] = 'f';
                }
                else if (matrix[row, col] == 'T')
                {
                    if (col - 1 < 0) col = size -1;
                    else col -= 1;
                    if (matrix[row, col] == 'F')
                    {
                        matrix[row, col] = 'f';
                        return true;
                    }
                    else matrix[row, col] = 'f';
                }
                else matrix[row, col] = 'f';
            }
            return won;
        }
    }
}