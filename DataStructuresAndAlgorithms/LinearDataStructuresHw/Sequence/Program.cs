using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = new List<int>();
            bool endInput = false;

            while (!endInput)
            {
                string inputLine = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    endInput = true;
                }
                else
                {
                    int parsedNumber = int.MinValue;
                    if (int.TryParse(inputLine, out parsedNumber) && parsedNumber > 0)
                    {
                        numbersInput.Add(parsedNumber);
                    }
                    else
                    {
                        Console.WriteLine("Ivalid number format!");
                    }
                }
            }

            Console.WriteLine("The sum of the numbers is: {0}.", MathUtilities.FindSum(numbersInput));
            Console.WriteLine("The average of the numbers is: {0}.", MathUtilities.FindAverage(numbersInput));
        }
    }
}
