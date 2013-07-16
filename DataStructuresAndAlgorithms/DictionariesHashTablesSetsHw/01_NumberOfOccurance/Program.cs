using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_NumberOfOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, double> occurances = new Dictionary<double, double>();
            double[] nums = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            foreach (var num in nums)
            {
                double counter = 0;
                if (occurances.ContainsKey(num))
                {
                    counter = occurances[num];
                }
                occurances[num] = counter + 1;
            }

            foreach (var pair in occurances)
            {
                Console.WriteLine("{0} -> {1}",pair.Key, pair.Value);
            }
        }
    }
}
