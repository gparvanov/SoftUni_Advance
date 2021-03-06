﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> tempStack = new Stack<int>();

            for (int i = 0; i < int.Parse(commands[0]); i++)
            {
                tempStack.Push(list[i]);
            }
            for (int i = 0; i < int.Parse(commands[1]); i++)
            {
                tempStack.Pop();
            }
            if (tempStack.Count == 0) Console.WriteLine(0);
            else if (tempStack.Contains(int.Parse(commands[2]))) Console.WriteLine("true");
            else
            {
                int min = int.MaxValue;
                while (tempStack.Count != 0)
                {
                    int currentNumber = tempStack.Pop();
                    if (currentNumber < min) min = currentNumber;
                }
                Console.WriteLine(min);
            }
        }
    }
}