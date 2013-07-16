using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts
{
    public interface ISorter<T> where T : IComparable<T>
    {
        void Sort(IList<T> collection);
    }
}
