using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());            
            StringBuilder text = new StringBuilder();
            Stack<string> versions = new Stack<string>();            

            for (int i = 0; i < operations; i++)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0] == "1")
                {
                    versions.Push(text.ToString());
                    text.Append(command[1]);                    
                }
                else if (command[0] == "2")
                {
                    int chars = int.Parse(command[1]);
                    if (text.Length >= chars)
                    {
                        versions.Push(text.ToString());
                        text = text.Remove(text.Length - chars,chars);
                    }
                }
                else if (command[0] == "3")
                {
                    int position = int.Parse(command[1]) - 1 ;                    
                    if (position >= 0 && position < text.Length)
                    {
                        Console.WriteLine(text[position]);
                    }
                }
                else if (command[0] == "4")
                {
                    if (versions.Count != 0) text = new StringBuilder(versions.Pop());                    
                }
            }
        }
    }
}