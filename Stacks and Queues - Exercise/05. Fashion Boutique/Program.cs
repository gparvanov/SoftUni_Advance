using System;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] totalClothes = Console.ReadLine().Split();

            Stack<int> tempStack = new Stack<int>();

            foreach (var cloth in totalClothes)
            {
                tempStack.Push(int.Parse(cloth));
            }
            int racks = 1;

            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRackLoaded = 0;
            while (tempStack.Count != 0)
            {
                int currentCloth = tempStack.Peek();
                if(rackCapacity >= currentRackLoaded + currentCloth)
                {
                    tempStack.Pop();
                    currentRackLoaded += currentCloth;
                }                
                else
                {
                    racks++;
                    currentRackLoaded = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
