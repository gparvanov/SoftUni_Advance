using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                PrintKnightName(name);
            }
        }
        private static void PrintKnightName(string name)
        {
            Console.WriteLine("Sir " + name);
        }
    }
}
