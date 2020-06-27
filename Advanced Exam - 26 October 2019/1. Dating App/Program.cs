using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int matches = 0;

            while(males.Count>0 && females.Count > 0)
            {
                int male = males.Peek();
                int female = females.Peek();
                if (male <=0 || female <=0)
                {
                    if (male <= 0) males.Pop();
                    if (female <= 0) females.Dequeue();
                }                                
                else if (male == female)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else if (male % 25 == 0 || female % 25 == 0)
                {
                    if (male % 25 == 0)
                    {
                        males.Pop();
                        males.Pop();
                    }
                    if (female % 25 == 0)
                    {
                        females.Dequeue();
                        females.Dequeue();
                    }
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(male - 2);
                }
            }
            Console.WriteLine($"Matches: {matches}");
            if (males.Count > 0) Console.WriteLine($"Males left: {string.Join(", ",males)}");            
            else Console.WriteLine("Males left: none");
            if (females.Count > 0) Console.WriteLine($"Females left: {string.Join(", ", females)}");
            else Console.WriteLine("Females left: none");
        }
    }
}