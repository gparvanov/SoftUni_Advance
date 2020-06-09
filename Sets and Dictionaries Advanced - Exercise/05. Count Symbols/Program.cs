using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] textSymbols = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();

            for (int i = 0; i < textSymbols.Length; i++)
            {
                char symbol = textSymbols[i];
                if (!occurences.ContainsKey(symbol))
                {
                    occurences[symbol] = 0;
                }
                occurences[symbol]++;
            }
            foreach (var symbol in occurences)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}