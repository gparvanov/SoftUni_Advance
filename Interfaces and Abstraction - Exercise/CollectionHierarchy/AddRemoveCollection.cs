using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
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
        public AddRemoveCollection()
        {
            Collection = new List<string>();
        }
        public int Add(string element)
        {
            Collection.Insert(0,element);
            return 0;
        }
        public string Remove()
        {
            string lastElement = Collection[Collection.Count-1];
            Collection.RemoveAt(Collection.Count - 1);
            return lastElement;
        }
    }
}