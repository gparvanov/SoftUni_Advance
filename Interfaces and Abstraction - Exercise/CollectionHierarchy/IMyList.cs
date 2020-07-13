using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IMyList
    {
        int Add(string element);
        string Remove();
        string Used { get; }
    }
}