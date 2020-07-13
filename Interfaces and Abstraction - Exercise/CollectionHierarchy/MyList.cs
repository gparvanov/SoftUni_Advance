using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IMyList
    {
        private List<string> collection;

        public List<string> Collection
        {
            get => collection;
            set
            {
                collection = value;
            }
        }
        public string Used 
        { 
            get => string.Join(" ", Collection); 
        }

        public MyList()
        {
            Collection = new List<string>();            
        }
        public int Add(string element)
        {
            Collection.Insert(0, element);
            return 0;
        }
        public string Remove()
        {
            string lastElement = Collection[0];
            Collection.RemoveAt(0);
            return lastElement;
        }
    }
}