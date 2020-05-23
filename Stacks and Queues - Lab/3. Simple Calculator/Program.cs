using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();
            text.Reverse();
            Stack<string> tempStack = new Stack<string>();
            foreach (var element in text)
            {
                tempStack.Push(element);                
            }            
            int sum = 0;            
            sum += int.Parse(tempStack.Pop());
            while (tempStack.Count != 0)
            {                
                string sign = tempStack.Pop();
                int currentNumber = int.Parse(tempStack.Pop());
                if (sign == "+") sum += currentNumber;
                else if (sign == "-") sum -= currentNumber;                
            }
            Console.WriteLine(sum);
        }
    }
}