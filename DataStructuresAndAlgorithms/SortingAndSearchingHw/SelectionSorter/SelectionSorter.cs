using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        IList<T> theList= new IList<T>();
        int listLen = theList.Count;

        public void Sort(IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("collection", "The collection you want to sort must not be null!");
            }
            int min;
            for (int i = 0; i < listLen-1; i++)
            {
                min = i;

                for (int j = i+1; j < listLen; j++)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    T swapVal = list[i];
                    list[i] = list[min];
                    list[min] = swapVal;
                }
            }
        }
    }
}
