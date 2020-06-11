using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string condition = Console.ReadLine();

            PrintRequiredElements(numbers, condition);
        }

        private static void PrintRequiredElements(int[] numbers, string condition)
        {
            switch (condition)
            {
                case "odd":
                    for (int i = numbers[0]; i <= numbers[1]; i++)
                    {
                        if (i % 2 != 0) Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                case "even":
                    for (int i = numbers[0]; i <= numbers[1]; i++)
                    {
                        if (i % 2 == 0) Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}