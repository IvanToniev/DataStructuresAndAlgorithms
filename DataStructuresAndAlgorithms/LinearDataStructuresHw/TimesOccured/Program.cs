﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesOccured
{
    class Program
    {
        static IDictionary<T, int> GroupByOccurrence<T>(IEnumerable<T> elements)
        {
            return elements.GroupBy(el => el).ToDictionary(group => group.Key, group => group.Count());
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Console.WriteLine(string.Join(" ", GroupByOccurrence(numbers)));
        }
    }
}
