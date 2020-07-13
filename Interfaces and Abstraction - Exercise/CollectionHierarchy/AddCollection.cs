using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollection
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
        public AddCollection()
        {
            Collection = new List<string>();
        }
        public int Add(string element)
        {
            Collection.Add(element);
            return Collection.Count -1 ;
        }
    }
}