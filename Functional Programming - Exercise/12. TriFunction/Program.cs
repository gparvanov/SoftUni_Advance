using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int charSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            bool winnerFound = false;
            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                winnerFound = WinnerName(currentName, charSum);
                if(winnerFound)
                {
                    Console.WriteLine(currentName);
                    return;
                }
            }            
        }
        private static bool WinnerName(string currentName, int charSum)
        {
            int currentNameSum = 0;
            for (int i = 0; i < currentName.Length; i++)
            {
                currentNameSum += currentName[i];
            }
            if (currentNameSum >= charSum) return true;
            else return false;
        }
    }
}