using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            int numOfLines = int.Parse(Console.ReadLine());
            string[] input = new string[numOfLines];
            for (int i = 0; i < numOfLines; i++)
            {
                line = Console.ReadLine();
                if (line == null || line == "\r\n" || line == string.Empty)
                {
                    break;
                }
                input[i]=(line);
            }

            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }

            string sbToString = sb.ToString().Trim();

            for (int i = 0; i <= sbToString.Length - 1; i++)
            {
                for (int j = i + 1; j < sbToString.Length; j++)
                {
                    if (sbToString[i] == sbToString[j])
                    {
                        sbToString = sbToString.Remove(i, 1);
                    }
                }
            }

            char[] sorted = new char[sbToString.Length];
            for (int i = 0; i < sbToString.Length; i++)
			{
			 sorted[i]=sbToString[i];
			}
            //Array.Sort<char>(sorted);

            foreach (var item in sorted)
	        {
		        Console.Write(item);
	        }
        }
    }
}
