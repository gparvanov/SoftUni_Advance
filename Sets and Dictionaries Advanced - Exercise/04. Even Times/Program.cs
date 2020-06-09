using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < rows; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber] = 0;
                }
                numbers[currentNumber]++;
            }
            var result = numbers.Where(x => x.Value % 2 == 0);
            foreach (var number in result)
            {                
                Console.WriteLine(number.Key);
            }
        }
    }
}
