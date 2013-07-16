using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Businessmen
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger cat = (Factorial(num) / (Factorial(num / 2 + 1) * Factorial(num / 2)));
            Console.WriteLine(cat);
            
        }

        static BigInteger Factorial(BigInteger n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
