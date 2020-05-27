using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> tempStack = new Stack<char>();
            foreach (var symbol in text)
            {
                if (symbol == '{' || symbol == '[' || symbol == '(' || symbol == ' ') tempStack.Push(symbol);
                else if(symbol == '}' || symbol == ']' || symbol == ')' || symbol == ' ')
                {
                    if(tempStack.Count==0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    char openingSymbol = tempStack.Pop();
                    bool isBalanced = true;
                    if (symbol == '}' && openingSymbol != '{') isBalanced = false;
                    if (symbol == ']' && openingSymbol != '[') isBalanced = false;
                    if (symbol == ')' && openingSymbol != '(') isBalanced = false;
                    if (symbol == ' ' && openingSymbol != ' ') isBalanced = false;
                    if (!isBalanced)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}