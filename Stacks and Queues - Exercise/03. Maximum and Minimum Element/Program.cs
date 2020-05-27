using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> tempStack = new Stack<int>();
            for (int i = 1; i <= queries; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if(commands[0] == "1")
                {
                    int element = int.Parse(commands[1]);
                    tempStack.Push(element);
                }
                else if ( commands[0] == "2")
                {
                    if(tempStack.Count!=0) tempStack.Pop();
                }
                else if ( commands[0] == "3")
                {
                    if (tempStack.Count != 0)
                    {
                        List<int> tempList = tempStack.ToList();
                        Console.WriteLine(tempList.Max());
                    }
                }
                else if ( commands[0] == "4")
                {
                    if (tempStack.Count != 0)
                    {
                        List<int> tempList = tempStack.ToList();
                        Console.WriteLine(tempList.Min());
                    }
                }             
            }
            Console.WriteLine(string.Join(", ",tempStack));
        }
    }
}