using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            int removesCount = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            List<int> coll1Result = new List<int>();
            List<int> coll2Result = new List<int>();
            List<int> coll3Result = new List<int>();
            for (int i = 0; i < elements.Length; i++)
            {
                coll1Result.Add(addCollection.Add(elements[i]));
                coll2Result.Add(addRemoveCollection.Add(elements[i]));
                coll3Result.Add(myList.Add(elements[i]));                
            }
            Console.WriteLine(string.Join(" ",coll1Result));
            Console.WriteLine(string.Join(" ",coll2Result));
            Console.WriteLine(string.Join(" ",coll3Result));

            //Console.WriteLine(myList.Used);

            List<string> coll2Removes = new List<string>();
            List<string> coll3Removes = new List<string>();

            for (int i = 0; i < removesCount; i++)
            {
                coll2Removes.Add(addRemoveCollection.Remove());
                coll3Removes.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", coll2Removes));
            Console.WriteLine(string.Join(" ", coll3Removes));
        }
    }
}