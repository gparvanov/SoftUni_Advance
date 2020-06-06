using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> values = new Dictionary<double, int>();
            Queue<double> input = new Queue<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());

            while (input.Count!=0)
            {
                double number = input.Dequeue();
                if (!values.ContainsKey(number))
                {
                    values[number] = 0;
                }
                values[number]++;
            }
            foreach (var element in values)
            {
                Console.WriteLine($"{element.Key} - {element.Value} times");
            }
        }
    }
}