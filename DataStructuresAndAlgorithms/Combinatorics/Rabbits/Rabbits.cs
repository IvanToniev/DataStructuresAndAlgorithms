﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbits
{
    class Rabbits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of the rabbits.");
            int count = int.Parse(Console.ReadLine());
            int[] replies = new int[count];
            for (int i = 0; i < count; i++)
            {
                replies[i] = int.Parse(Console.ReadLine());
            }
            int answer = getMinimum(replies);
            Console.WriteLine(answer);
        }

        private static int getMinimum(int[] replies)
        {
            int[] cache = new int[1000002];
            for (int i = 0; i < replies.Length; i++)
            {
                cache[replies[i] + 1]++;
            }
            int minCount = 0;
            for (int i = 0; i < cache.Length; i++)
            {
                if (cache[i] == 0) continue;
                if (cache[i] <= i) minCount += i;
                else minCount += (int)Math.Ceiling((double)cache[i] / i) * i;
            }
            return minCount;
        }
    }
}
