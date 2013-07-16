using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_LinkedListImpl
{
    class LinkedListMain
    {
        public static void main() 
        {
            CustomLinkedList<int> customList = new CustomLinkedList<int>();

            CustomLinkedList<string> anotherList = new CustomLinkedList<string>(
                new List<string> { "pesho", "gosho", "sasho", "misho" });

            Console.WriteLine(anotherList);
            Console.WriteLine("First: " + anotherList.First.Value);
            Console.WriteLine("Last: " + anotherList.Last.Value);
            Console.WriteLine();

            customList.AddFirst(15);
            customList.AddFirst(20);
            Console.WriteLine(customList);

            customList.AddLast(50);
            customList.AddLast(100);
            Console.WriteLine(customList);

            anotherList.RemoveFirst();
            Console.WriteLine(anotherList);

            customList.RemoveLast();
            Console.WriteLine(customList);

            customList.Remove(customList.First.Next);
            Console.WriteLine(customList);

            anotherList.Clear();
            Console.WriteLine(anotherList.Count == 0 && anotherList.First == null && anotherList.Last == null);
        }
    }
}
