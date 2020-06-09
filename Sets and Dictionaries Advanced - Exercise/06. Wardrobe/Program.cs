using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string,int>>();

            for (int i = 0; i < rows; i++)
            {
                string[] inputData = Console.ReadLine().Split(" -> ");
                string color = inputData[0];
                List<string> inputCloths = new List<string>(inputData[1].Split(",").ToList());
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string,int>();
                }
                foreach (var cloth in inputCloths)
                {
                    if (!wardrobe[color].ContainsKey(cloth)) 
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;
                }
            }
            string[] searchCloth = Console.ReadLine().Split();
            string colorType = searchCloth[0];
            string clothType = searchCloth[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                var innerDictionary = item.Value;
                foreach (var element in innerDictionary)
                {
                    if(item.Key == colorType && element.Key == clothType)
                    {
                        Console.WriteLine($"* {element.Key} - {element.Value} (found!)");
                    }
                    else Console.WriteLine($"* {element.Key} - {element.Value}");
                }
            }
        }
    }
}