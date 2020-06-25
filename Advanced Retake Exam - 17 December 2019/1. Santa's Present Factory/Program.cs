using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materialBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Dictionary<string, int> toys = new Dictionary<string, int>()
            {
                {"Doll", 0},
                {"Wooden train", 0},
                {"Teddy bear", 0},
                {"Bicycle",0}
            };
            bool comboPresent = false;
            int toysCrafted = 0;
            while(materialBox.Count>0 && magicLevel.Count > 0)
            {
                int currentBox = materialBox.Peek();
                int currentMagicLevel = magicLevel.Peek();
                int totalMagicLevel = currentBox * currentMagicLevel;

                if (totalMagicLevel == 150)
                {
                    materialBox.Pop();
                    magicLevel.Dequeue();
                    toys["Doll"]++;
                    toysCrafted++;
                }
                else if (totalMagicLevel == 250)
                {
                    materialBox.Pop();
                    magicLevel.Dequeue();
                    toys["Wooden train"]++;
                    toysCrafted++;
                }
                else if (totalMagicLevel == 300)
                {
                    materialBox.Pop();
                    magicLevel.Dequeue();
                    toys["Teddy bear"]++;
                    toysCrafted++;
                }
                else if (totalMagicLevel == 400)
                {
                    materialBox.Pop();
                    magicLevel.Dequeue();
                    toys["Bicycle"]++;
                    toysCrafted++;
                }
                else if (totalMagicLevel < 0)
                {
                    int sum = materialBox.Pop() + magicLevel.Dequeue();
                    materialBox.Push(sum);
                }
                else if ( totalMagicLevel > 0)
                {
                    magicLevel.Dequeue();
                    materialBox.Pop();
                    materialBox.Push(currentBox + 15);
                }
                else if (currentBox == 0 || currentMagicLevel == 0)
                {
                    if (currentBox == 0) materialBox.Pop();
                    if (currentMagicLevel == 0) magicLevel.Dequeue();
                }                
            }
            if ((toys["Doll"] > 0 && toys["Wooden train"] > 0) ||
                (toys["Teddy bear"] > 0 && toys["Bicycle"] > 0))
            {
                comboPresent = true;             
            }
            if (comboPresent) Console.WriteLine("The presents are crafted! Merry Christmas!");
            else Console.WriteLine("No presents this Christmas!");
            if (materialBox.Count > 0) Console.WriteLine($"Materials left: {string.Join(", ",materialBox)}");
            if (magicLevel.Count > 0) Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");

            if (toysCrafted > 0)
            {
                var result = toys.Where(x => x.Value>0).OrderBy(x => x.Key);
                foreach (var toy in result)
                {
                    Console.WriteLine($"{toy.Key}: {toy.Value}");
                }
            }
        }
    }
}