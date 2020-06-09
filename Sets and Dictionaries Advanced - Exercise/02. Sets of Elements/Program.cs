using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Dictionary<int, int> frequences = new Dictionary<int, int>();

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < sizes[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
                if (!frequences.ContainsKey(number))
                {
                    frequences[number] = 1;
                }
            }
            for (int i = 0; i < sizes[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
                if (frequences.ContainsKey(number))
                {
                    frequences[number] = 2;
                }
            }            
            var result = frequences.Where(x => x.Value > 1);

            foreach (var digit in result)
            {
                Console.Write($"{digit.Key} ");
            }
            Console.WriteLine();
        }
    }
}