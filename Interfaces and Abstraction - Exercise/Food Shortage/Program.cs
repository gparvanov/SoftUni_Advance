using System;
using System.Collections.Generic;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputRows = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 0; i < inputRows; i++)
            {
                string[] inputBuyersData = Console.ReadLine().Split();

                if(inputBuyersData.Length == 4)
                {
                    string citizenName = inputBuyersData[0];
                    int citizenAge = int.Parse(inputBuyersData[1]);
                    string citizenId = inputBuyersData[2];
                    string citizenBirthday = inputBuyersData[3];
                    Citizen citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthday);
                    buyers.Add(citizen);

                }
                else if (inputBuyersData.Length == 3)
                {
                    string rebelName = inputBuyersData[0];
                    int rebelAge = int.Parse(inputBuyersData[1]);
                    string rebelGroup = inputBuyersData[2];
                    Rebel rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                    buyers.Add(rebel);
                }
            }

            string person = Console.ReadLine();
            while (person != "End")
            {
                foreach (var creature in buyers)
                {
                    if (creature is Citizen citizen)
                    {
                        if(citizen.Name == person) citizen.BuyFood();
                    }
                    else if (creature is Rebel rebel)
                    {
                        if(rebel.Name == person ) rebel.BuyFood();
                    }
                }
                person = Console.ReadLine();
            }
            int sum = 0;
            foreach (var buyer in buyers)
            {
                sum += buyer.Food;
            }
            Console.WriteLine(sum);
        }
    }
}