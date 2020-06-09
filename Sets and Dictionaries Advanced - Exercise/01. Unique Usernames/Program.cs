using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < rows; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}