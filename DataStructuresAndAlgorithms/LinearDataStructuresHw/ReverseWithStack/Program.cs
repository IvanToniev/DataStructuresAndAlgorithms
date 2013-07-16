using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers do you want to enter?");
            int numsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers you want to see reversed.");
            Stack<int> numsStack = new Stack<int>();

            for (int i = 0; i < numsCount; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                numsStack.Push(element);
            }

            Console.WriteLine("The numbers reversed are:");

            for (int i = 0; i < numsCount; i++)
            {
                Console.WriteLine(numsStack.Pop());
            }
        }
    }
}
