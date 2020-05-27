using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> tempQue = new Queue<int>();

            for (int i = 0; i < int.Parse(commands[0]); i++)
            {
                tempQue.Enqueue(list[i]);
            }
            for (int i = 0; i < int.Parse(commands[1]); i++)
            {
                tempQue.Dequeue();
            }
            if (tempQue.Count == 0) Console.WriteLine(0);
            else if (tempQue.Contains(int.Parse(commands[2]))) Console.WriteLine("true");
            else
            {
                int min = int.MaxValue;
                while (tempQue.Count != 0)
                {
                    int currentNumber = tempQue.Dequeue();
                    if (currentNumber < min) min = currentNumber;
                }
                Console.WriteLine(min);
            }
        }
    }
}