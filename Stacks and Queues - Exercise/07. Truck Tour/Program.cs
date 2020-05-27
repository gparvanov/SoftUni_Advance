using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int totalAmount = 0;
                bool isCompleted = true;
                Queue<string> tempQue = new Queue<string>(pumps);
                for (int j = 0; j < n; j++)
                {                    
                    string currentPump = tempQue.Dequeue();
                    int[] currentpumpValues = currentPump.Split().Select(int.Parse).ToArray();
                    int currentAmount = currentpumpValues[0];
                    int distance = currentpumpValues[1];
                    totalAmount += currentAmount;
                    if (totalAmount >= distance) totalAmount -= distance;
                    else
                    {
                        isCompleted = false;
                        break;
                    }                                        
                }
                if (isCompleted)
                {
                    index = i;
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(index);
        }
    }
}