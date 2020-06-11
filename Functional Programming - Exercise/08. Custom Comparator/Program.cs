using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 ) Console.Write(numbers[i] + " ");
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0) Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
