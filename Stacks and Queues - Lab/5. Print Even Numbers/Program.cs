using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> que = new Queue<int>();

            foreach (var element in list)
            {
                if(element % 2 == 0) que.Enqueue(element);
            }
            Console.WriteLine(string.Join(", ",que));
        }
    }
}