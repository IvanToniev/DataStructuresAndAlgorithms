using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            Console.WriteLine("Enter some numbers: ");

            string line = null;

            do
            {
                line = Console.ReadLine();
                if (line != string.Empty)
                {
                    numbers.AddLast(int.Parse(line));
                }
            }
            while (line != string.Empty);

            var node = numbers.First;
            while (node != null)
            {
                var next = node.Next;
                if (node.Value < 0)
                    numbers.Remove(node);
                node = next;
            }

            Console.WriteLine(string.Join(" -> ", numbers));
            Console.ReadLine();
        }
    }
}
