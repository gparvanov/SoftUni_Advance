using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Dictionary<string, double> products = new Dictionary<string, double>();
            string[] peopleData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var human in peopleData)
            {
                string[] humanDetails = human.Split("=");
                string humanName = humanDetails[0];
                double humanMoney = double.Parse(humanDetails[1]);
                try
                {
                    Person currentPerson = new Person(humanName, humanMoney);
                    people.Add(currentPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            string[] productsData = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in productsData)
            {
                string[] productDetails = item.Split("=");
                string productName = productDetails[0];
                double productPrice = double.Parse(productDetails[1]);
                try
                {
                    Product currentProduct = new Product(productName, productPrice);
                    products[productName] = productPrice;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] details = command.Split();
                string name = details[0];
                string item = details[1];
                foreach (var human in people)
                {
                    if (human.Name == name)
                    {
                        if (human.Money - products[item] >= 0)
                        {
                            human.Money -= products[item];                            
                            human.Bag.Add(item);
                            Console.WriteLine($"{name} bought {item}");
                        }
                        else
                        {
                            Console.WriteLine($"{name} can't afford {item}");
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var client in people)
            {
                if (client.Bag.Count == 0)
                {
                    Console.WriteLine($"{client.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{client.Name} - {string.Join(", ", client.Bag)}");
                }
            }
        }
    }
}
