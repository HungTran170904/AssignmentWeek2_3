using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFileExplorer
{
    public partial class FileExplorerForm : Form
    {
        public FileExplorerForm()
        {
            InitializeComponent();
            string rootPath = @"D:\";
            if (Directory.Exists(rootPath))
            {
                TreeNode root = new TreeNode() { Tag = rootPath, Text = "D:" };
                treeView.Nodes.Add(root);
                loadDirectories(root);
            }
        }

        public void loadDirectories(TreeNode treeNode)
        {
            try
            {
                string[] dirPaths = Directory.GetDirectories(treeNode.Tag.ToString());
                foreach (string dirPath in dirPaths)
                {
                    TreeNode subTreeNode = new TreeNode() { Tag = dirPath, Text = Path.GetFileName(dirPath) };
                    treeNode.Nodes.Add(subTreeNode);
                    loadDirectories(subTreeNode);
                }
            }
            catch
            {
                return;
            }
        }
        private async Task<bool> copyFile(string sourcePath, string destPath)
        {
            byte[] buffer = new byte[4096];
            using (var sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (var destStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            using (var sourceBuffer = new BufferedStream(sourceStream))
            using (var destBuffer = new BufferedStream(destStream))
            {
                int bytesRead;
                while ((bytesRead = sourceBuffer.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destBuffer.Write(buffer, 0, bytesRead);
                }
                return true;
            }
        }
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node != null)
            {
                pathTextbox.Text = node.Tag.ToString();
            }
        }
        private void showItemsOnListView(string path)
        {
            try
            {
                listView.Items.Clear();
                listView.Tag = path;
                string[] dirPaths = Directory.GetDirectories(path);
                foreach (string dirPath in dirPaths)
                {
                    ListViewItem item = new ListViewItem(new string[] { Text = Path.GetFileName(dirPath) }, 0);
                    item.Tag = dirPath;
                    listView.Items.Add(item);
                }
                string[] filePaths = Directory.GetFiles(path);
                foreach (string filePath in filePaths)
                {
                    ListViewItem item = new ListViewItem(new string[] { Path.GetFileName(filePath) }, 1);
                    item.Tag = filePath;
                    listView.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry. There is an error when trying to open path " + path);
            }
        }
        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.Tag.ToString();
            showItemsOnListView(path);
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem clickedItem = listView.GetItemAt(e.X, e.Y);
                string path = clickedItem.Tag.ToString();
                if (clickedItem != null)
                {
                    FileAttributes attributes = File.GetAttributes(path);

                    if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        showItemsOnListView(path);
                    }
                    else
                    {
                        MessageBox.Show("The path refers to a file.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The specified path does not exists");
            }
        }

        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem clickedItem = listView.GetItemAt(e.X, e.Y);
                if (clickedItem != null)
                {
                    contextMenuStrip.Items[0].Enabled = true;
                    contextMenuStrip.Items[1].Enabled = false;
                    contextMenuStrip.Items[2].Enabled = true;
                    contextMenuStrip.Tag = clickedItem.Tag;
                }
                else
                {
                    string path = listView.Tag.ToString();
                    contextMenuStrip.Items[0].Enabled = false;
                    contextMenuStrip.Items[1].Enabled = true;
                    contextMenuStrip.Items[2].Enabled = false;
                }
                contextMenuStrip.Show(listView, e.Location);
            }
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Items[0].Tag = contextMenuStrip.Tag;
        }

        private async void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip.Items[0].Tag != null)
            {
                string copiedPath = contextMenuStrip.Items[0].Tag.ToString();
                try
                {
                    FileAttributes attributes = File.GetAttributes(copiedPath);
                    if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        MessageBox.Show("Unable to paste the whole folder");
                    }
                    else
                    {
                        string fileName = Path.GetFileName(copiedPath);
                        string listViewPath = listView.Tag.ToString();
                        string destPath = Path.Combine(listViewPath, fileName);
                        bool success = await copyFile(copiedPath, destPath);
                        if (success && listViewPath.Equals(listView.Tag.ToString()))
                        {
                            ListViewItem newItem = new ListViewItem(new string[] { Text = fileName }, 1);
                            newItem.Tag = destPath;
                            listView.Items.Add(newItem);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There is an error when trying to paste the copied path");
                }
            }
        }

        private async void deleteMenuItem_Click(object sender, EventArgs e)
        {
            string path = contextMenuStrip.Tag.ToString();
            string listViewPath = listView.Tag.ToString();
            try
            {
                FileAttributes attributes = File.GetAttributes(path);
                if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {

                }
                else
                {
                    await Task.Run(() => File.Delete(path));
                }
                if (listViewPath.Equals(listView.Tag.ToString()))
                {
                    ListViewItem deletedItem=null;
                    foreach(ListViewItem item in listView.Items){
                        if (item.Tag.ToString().Equals(path))
                        {
                            deletedItem= item;
                            break;
                        }
                    }
                    if(deletedItem != null) listView.Items.Remove(deletedItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }
        }
    }
}
