using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers. Enter empty line to stop.");
            List<int> numsList = new List<int>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == string.Empty)
                {
                    break;
                }

                int parsedNum;

                bool isParsed = int.TryParse(inputLine, out parsedNum);

                if (isParsed)
                {
                    numsList.Add(parsedNum);
                }
            }

            numsList.Sort();

            Console.WriteLine("The sorted numbers are:");
            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}
