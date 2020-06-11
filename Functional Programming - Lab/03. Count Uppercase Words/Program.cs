using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text)
            {
                bool isCapitol = IsCapitalLetter(word);
                if (isCapitol) Console.WriteLine(word);
            }
        }
        private static bool IsCapitalLetter(string word)
        {
            bool isCapitol = false;            
            isCapitol = char.IsUpper(char.Parse(word.Substring(0,1)));
            return isCapitol;
        }
    }
}