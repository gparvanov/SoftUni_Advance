using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string command = Console.ReadLine();

            while(command != "End")
            {
                if(command == "Paid")
                {
                    while (names.Count != 0) Console.WriteLine(names.Dequeue());
                }
                else
                {
                    names.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
