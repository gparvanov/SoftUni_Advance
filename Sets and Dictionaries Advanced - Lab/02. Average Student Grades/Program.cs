using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < rows; i++)
            {
                string[] incomingData = Console.ReadLine().Split();
                string name = incomingData[0];
                decimal value = decimal.Parse(incomingData[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(value);
            }
            foreach (var student in students)
            {
                string name = student.Key;
                var values = student.Value;
                decimal average = student.Value.Average();
                Console.Write($"{name} -> ");
                foreach (var value in values)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}