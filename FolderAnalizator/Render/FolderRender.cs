using FolderScanner.Models;
using System.Windows.Forms;

namespace FolderAnalizator
{
    public class FolderRender
    {
        public static void Render(Folder fs, TreeView view)
        {
            view.Update();
            view.Nodes.Clear();

            TreeNode node = new TreeNode(fs.Name + " " + fs.GetSize(), 0, 1);
            FillTree(node, fs);
            view.Nodes.Add(node);

            view.EndUpdate();
        }

        private static void FillTree(TreeNode node, Folder fs)
        {
            foreach (var item in fs.Folders)
            {
                TreeNode nd = new TreeNode(item.Name + " " + item.GetSize(), 0, 1);
                FillTree(nd, item);
                node.Nodes.Add(nd);
            }

            foreach (var item in fs.Files)
            {
                TreeNode nd = new TreeNode(item.Name + " - " + item.GetSize(), 0, 2);
                node.Nodes.Add(nd);
            }
        }
    }
}
