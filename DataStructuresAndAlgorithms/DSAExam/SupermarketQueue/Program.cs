using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SupermarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            SupermarketQueue queue = new SupermarketQueue();
            StringBuilder input = new StringBuilder();
            string line = "";
            using (var stream = new StreamReader(Console.OpenStandardInput()))
            {
                while (line != null)
                {
                    line = stream.ReadLine();
                    if (line == "End")
                    {

                        break;
                    }
                    else
                    {
                        input.AppendLine(line);
                    }
                }
                ExacuteCommands(input, queue);
                stream.Close();
            }
        }          

        private static void ExacuteCommands(StringBuilder input, SupermarketQueue queue)
        {
            string inputToString = input.ToString().Trim();
            char[] delimiters = new char[] { '\r', '\n' };
            string[] inputLines = inputToString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string[] currentLine;
            for (int i = 0; i < inputLines.Length; i++)
            {
                currentLine = inputLines[i].Split(' ');

                switch (currentLine[0])
                {
                    case "Append":
                        {
                            queue.Append(currentLine[1]);
                            break;
                        }
                    case "Insert":
                        {
                            queue.Insert(int.Parse(currentLine[1]), currentLine[2]);
                            break;
                        }
                    case "Find":
                        {
                            queue.Find(currentLine[1]);
                            break;
                        }
                    case "Serve":
                        {
                            queue.Serve(int.Parse(currentLine[1]));
                            break;
                        }
                }
            }

        }
    }

    class SupermarketQueue
    {
        private List<string> queue;
        public SupermarketQueue()
        {
            this.queue = new List<string>();
        }

        public void Append(string name)
        {
            queue.Add(name);
            Console.WriteLine("OK");
        }

        public void Insert(int position, string name)
        {
            if (position > -1 && position <= queue.Count)
            {
                queue.Insert(position, name);
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void Find(string name)
        {
            int counter = 0;
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue[i] == name)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        public void Serve(int count)
        {
            if (count > queue.Count || count < 0)
            {
                Console.WriteLine("Error");
            }

            else
            {
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    output.Append(queue[i] + ' ');
                }
                queue.RemoveRange(0, count);
                Console.WriteLine(output.ToString().Trim());
            }
        }
    }
}