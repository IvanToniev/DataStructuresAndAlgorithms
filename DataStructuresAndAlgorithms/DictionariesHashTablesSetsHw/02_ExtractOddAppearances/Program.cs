using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExtractOddAppearances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] someStrings = new string[] { "c#", "c#", "c#", "c++", "c++", "c++", "c++" };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int counter = 0;

            foreach (var pair in someStrings)
            {
                int count = 0;
                if (dict.ContainsKey(pair))
                {
                    count = dict[pair];
                }
                dict[pair] = count + 1;
            }

            foreach (var pair in dict)
            {
                if (pair.Value % 2 == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}
