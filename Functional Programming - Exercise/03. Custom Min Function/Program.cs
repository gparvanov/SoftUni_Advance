using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            FindMinElement(numbers);
        }
        private static void FindMinElement(List<int> numbers)
        {
            int min = numbers.Min();
            Console.WriteLine(min);
        }
    }
}