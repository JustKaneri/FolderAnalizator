using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderScanner.Models
{
    public class Folder : PrototypeFile
    {
        public List<MediaFile> Files { get; set; }
        public List<Folder> Folders { get; set; }

        public Folder(string name, double size) : base(name, size)
        {
            Files = new List<MediaFile>();
            Folders = new List<Folder>();
        }
    }
}
