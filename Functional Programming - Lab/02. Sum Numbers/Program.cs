using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var count = numbers.ToList().Count();
            Console.WriteLine(count);
            var sum = numbers.Sum(x => x);
            Console.WriteLine(sum);
        }
    }
}