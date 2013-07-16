using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KeepFiles
{
    class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public File[] Files { get; set; }

        public Folder[] ChildFolders { get; set; }
    }
}
