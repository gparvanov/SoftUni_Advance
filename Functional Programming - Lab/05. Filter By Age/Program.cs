using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < rows; i++)
            {
                string[] data = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                int age = int.Parse(data[1]);
                if (!people.ContainsKey(name))
                {
                    people[name] = age;
                }                
            }
            string condition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            OutputResults(people, condition, ageLimit, format);
        }
        private static void OutputResults(Dictionary<string,int> people, string condition, int ageLimit, string format)
        {           
            if(condition == "younger")
            {
                var result = people.Where(x => x.Value < ageLimit);
                foreach (var person in result)
                {
                    if (format == "name") Console.WriteLine($"{person.Key}");
                    else if (format == "age") Console.WriteLine($"{person.Value}");
                    else if (format == "name age") Console.WriteLine($"{person.Key} - {person.Value}"); 
                }
            }
            else 
            {
                var result = people.Where(x => x.Value >= ageLimit);
                foreach (var person in result)
                {
                    if (format == "name") Console.WriteLine($"{person.Key}");
                    else if (format == "age") Console.WriteLine($"{person.Value}");
                    else if (format == "name age") Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }           
        }
    }
}