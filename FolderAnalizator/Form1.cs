using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderAnalizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Statistic = new FolderStatistic();
            var result = GetFolders(Directory.GetCurrentDirectory());
            ShowDirectory(result);

            treeView1.ExpandAll();
        }

        public FolderStatistic Statistic;

        public void ShowDirectory(Folder fs)
        {
            TreeNode node = new TreeNode(fs.Name + " " + fs.Size, 0, 1);
            FillTree(node, fs);
            treeView1.Nodes.Add(node);
        }

        public void FillTree(TreeNode node, Folder fs)
        {
            foreach (var item in fs.Folders)
            {
                TreeNode nd = new TreeNode(item.Name + " " + item.Size,0,1);
                FillTree(nd, item);
                node.Nodes.Add(nd);
            }

            foreach (var item in fs.Files)
            {
                TreeNode nd = new TreeNode(item.Name + " - " + item.Size,0,2);
                node.Nodes.Add(nd);
            }
        }

        public Folder GetFolders(string Path)
        {
            DirectoryInfo current = new DirectoryInfo(Path);

            List<MediaFile> fil = new List<MediaFile>();
            List<Folder> folders = new List<Folder>();
            double totalSize = 0;

            foreach (var item in current.GetFiles())
            {
                MediaFile mediaFile = new MediaFile(item.Name, item.Length, item.Extension);
                totalSize += item.Length;
                if (Statistic.CountType.ContainsKey(item.Extension))
                {
                    Statistic.CountType[item.Extension] += 1;
                    Statistic.TotalSizeType[item.Extension] += item.Length;
                }
                else
                {
                    Statistic.CountType.Add(item.Extension, 1);
                    Statistic.TotalSizeType.Add(item.Extension, item.Length);
                }
                fil.Add(mediaFile);
            }

            foreach (var item in current.GetDirectories())
            {
                Folder folder = GetFolders(item.FullName);
                totalSize += folder.Size;

                folders.Add(folder);
            }

            var result = new Folder(current.Name, totalSize);
            result.Files = fil;
            result.Folders = folders;

            return result;
        }

        public abstract class File
        {
            public string Name { get;  }
            public double Size { get; set; }

            public File(string name,double size)
            {
                Name = name;
                Size = size;
            }
        }

        public class FolderStatistic
        {
            public Dictionary<string, int> CountType = new Dictionary<string, int>();
            public Dictionary<string, long> TotalSizeType = new Dictionary<string, long>();
        }

        public class MediaFile : File
        {
            public string TypeFile { get; set; }

            public MediaFile(string name, double size, string type) : base(name, size)
            {
                TypeFile = type;
            }
        }

        public class Folder : File
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
}
