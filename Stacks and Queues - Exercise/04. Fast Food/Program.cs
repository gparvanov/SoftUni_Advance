using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> tempQue = new Queue<int>();

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var order in orders)
            {
                tempQue.Enqueue(order);
            }
            int maxOrder = 0;
            while(tempQue.Count != 0)
            {
                int currentOrder = tempQue.Peek();
                if (currentOrder > maxOrder) maxOrder = currentOrder;
                if (currentOrder <= foodQuantity)
                {
                    foodQuantity -= currentOrder;
                    tempQue.Dequeue();
                }
                else break;             
            }
            Console.WriteLine(maxOrder);

            if (tempQue.Count == 0) Console.WriteLine("Orders complete");
            else Console.WriteLine($"Orders left: {string.Join(" ",tempQue)}");
        }
    }
}