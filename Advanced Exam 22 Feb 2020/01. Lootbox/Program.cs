using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLoot = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondLoot = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int sumClaimedItems = 0;
            while(firstLoot.Any() && secondLoot.Any())
            {
                int firstLootElement = firstLoot.Peek();
                int secondLootElement = secondLoot.Peek();

                if((firstLootElement + secondLootElement) %2 == 0)
                {
                    sumClaimedItems += firstLootElement + secondLootElement;
                    firstLoot.Dequeue();
                    secondLoot.Pop();
                }
                else
                {
                    secondLoot.Pop();
                    firstLoot.Enqueue(secondLootElement);
                }
                if (firstLoot.Count == 0 || secondLoot.Count == 0) break;
            }
            if (firstLoot.Count == 0) Console.WriteLine("First lootbox is empty");
            else Console.WriteLine("Second lootbox is empty");
            if (sumClaimedItems > 100) Console.WriteLine($"Your loot was epic! Value: {sumClaimedItems}");
            else Console.WriteLine($"Your loot was poor... Value: {sumClaimedItems}");
        }
    }
}