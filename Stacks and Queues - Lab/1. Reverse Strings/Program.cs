using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var stackHolder = new Stack<char>();

            foreach(char symbol in inputText)
            {
                stackHolder.Push(symbol);
            }

            while (stackHolder.Count != 0)
            {
                Console.Write(stackHolder.Pop());
            }
            Console.WriteLine();
        }
    }
}
