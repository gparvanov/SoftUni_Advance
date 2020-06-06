using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < rows; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string continent = inputData[0];
                string country = inputData[1];
                string city = inputData[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                    continents[continent][country].Add(city);
                }
                else continents[continent][country].Add(city);                
            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                var innerDictionary = continent.Value;

                foreach (var country in innerDictionary)
                {
                    string name = country.Key;
                    var cities = country.Value;
                    Console.WriteLine($"{name} -> {string.Join(", ",cities)}");
                }
            }
        }
    }
}