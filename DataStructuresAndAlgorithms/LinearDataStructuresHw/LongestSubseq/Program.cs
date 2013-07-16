using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubseq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadNumbers();
            var resultList = LongestSequence(numbers);
            PrintNumbers(resultList);
        }

        public static List<int> LongestSequence(List<int> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("List is null.");
            }

            if (list.Count == 0)
            {
                throw new ArgumentOutOfRangeException("List has no elements.");
            }

            int currentNumber = list[0];
            int currentMax = 1;
            int longestMax = 1;
            int longestNumber = currentNumber;
            List<int> resultList = new List<int>();
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentNumber)
                {
                    currentMax++;
                }
                else
                {
                    currentNumber = list[i];
                    currentMax = 1;
                }
                if (currentMax > longestMax)
                {
                    longestMax = currentMax;
                    longestNumber = currentNumber;
                }

            }
            for (int i = 0; i < longestMax; i++)
            {
                resultList.Add(longestNumber);
            }
            return resultList;
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("Print numbers.");
            Console.WriteLine(string.Join(",", numbers));
        }

        private static List<int> ReadNumbers()
        {
            int n;
            string str;
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Enter number:");
                str = Console.ReadLine();
                if (int.TryParse(str, out n))
                {
                    numbers.Add(n);
                }
            }
            while (str != "");

            return numbers;
        }
    }
}
