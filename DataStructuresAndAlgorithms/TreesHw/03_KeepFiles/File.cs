using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KeepFiles
{
    class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public File(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public long Size { get; set; }
    }
}
