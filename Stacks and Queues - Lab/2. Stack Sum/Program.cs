using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            var tempStack = new Stack<int>();
            foreach (var digit in listDigits)
            {
                tempStack.Push(digit);
            }
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] inputCommand = command.Split();

                if(inputCommand[0].ToLower() == "add")
                {
                    tempStack.Push(int.Parse(inputCommand[1]));
                    tempStack.Push(int.Parse(inputCommand[2]));
                }
                else if ( inputCommand[0].ToLower() == "remove")
                {
                    if (int.Parse(inputCommand[1]) <= tempStack.Count && int.Parse(inputCommand[1]) >0 )
                    {
                        for (int i = 1; i <= int.Parse(inputCommand[1]); i++)
                        {
                            tempStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            int sum = 0;
            while (tempStack.Count != 0)
            {
                sum += tempStack.Pop();                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}