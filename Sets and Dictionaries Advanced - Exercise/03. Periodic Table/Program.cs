using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> elements = new SortedDictionary<string, int>();

            for (int i = 0; i < rows; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                foreach (var input in inputs)
                {
                    if (!elements.ContainsKey(input))
                    {
                        elements[input] = 0;
                    }
                    elements[input]++;
                }
            }
            foreach (var element in elements)
            {
                Console.Write($"{element.Key} ");
            }
            Console.WriteLine();
        }
    }
}