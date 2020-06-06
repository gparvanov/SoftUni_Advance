using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] data = command.Split(", ");
                string shop = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                if (shops.ContainsKey(shop) && !shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }                                
                command = Console.ReadLine();
            }            
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                var innerDictionary = shop.Value;
                foreach (var product in innerDictionary)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value.ToString("0.##")}");
                }
            }
        }
    }
}