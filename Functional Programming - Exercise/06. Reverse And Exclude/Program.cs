using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divisible = int.Parse(Console.ReadLine());

            ManipulateArray(numbers, divisible);
        }
        private static void ManipulateArray(List<int> numbers, int divisible)
        {
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % divisible != 0) Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}