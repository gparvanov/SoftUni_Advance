using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                Console.WriteLine(name); ;
            }
        }        
    }
}