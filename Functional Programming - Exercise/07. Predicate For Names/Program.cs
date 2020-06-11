using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringLenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            PrintFilteredNames(names, stringLenght);
        }

        private static void PrintFilteredNames(string[] names, int stringLenght)
        {
            foreach (var name in names)
            {
                if (name.Length <= stringLenght) Console.WriteLine(name);
            }
        }
    }
}