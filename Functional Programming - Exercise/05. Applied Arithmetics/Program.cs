using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while(command != "end")
            {
                ManipulateArray(numbers, command);
                command = Console.ReadLine();
            }
        }

        private static void ManipulateArray(int[] numbers, string command)
        {
            switch (command)
            {
                case "add":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]++;
                    }
                    break;
                case "multiply":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *=2;
                    }
                    break;
                case "subtract":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                    break;
                case "print": Console.WriteLine(string.Join(" ",numbers));                    
                    break;
            }
        }
    }
}