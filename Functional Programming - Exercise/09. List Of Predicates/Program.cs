using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> divisableNumbers = new Queue<int>();
            for (int i = 1; i <= endNumber; i++)
            {
                CheckDividers(dividers,i,divisableNumbers);
            }
            if (divisableNumbers.Count > 0) Console.WriteLine(string.Join(" ", divisableNumbers));
        }
        private static void CheckDividers(int[] dividers, int i, Queue<int> divisableNumbers)
        {
            bool divisable = false;
            foreach (var divider in dividers)
            {
                if (i % divider == 0) divisable = true;
                else
                {
                    divisable = false;
                    break;
                }
            }
            if (divisable) divisableNumbers.Enqueue(i);
        }
    }
}