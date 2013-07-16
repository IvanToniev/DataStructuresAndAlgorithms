using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02_TraverseFolder
{
    class Program
    {
        private static List<string> files = new List<string>();

        public static void Main()
        {
            string rootPath = @"C:\Program Files (x86)";
            string fileExtension = "*.dll";

            TraverseDirectory(rootPath, fileExtension);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        private static void TraverseDirectory(string currentPath, string fileExtension)
        {
            string[] currentDirFiles = Directory.GetFiles(currentPath, fileExtension);
            files.AddRange(currentDirFiles);

            string[] curretDirDirectories = Directory.GetDirectories(currentPath);
            foreach (var dir in curretDirDirectories)
            {
                TraverseDirectory(dir, fileExtension);
            }
        }
    }
}
