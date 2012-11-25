using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace File_System_Simulation
{
    public partial class Form1 : Form
    {
        //Initiate the tree data structure
        MyTree myTree = new MyTree();
        public Form1()
        {
            
            InitializeComponent();
            Fill_Mytree();

        }

        private void CreateFiles_Click(object sender, EventArgs e)
        {
            if (FileName.Text.Length == 0)
            {
                MessageBox.Show("Please insert a valid file name");
                FileName.BackColor = Color.Red;
            }

            else
            {

                FileName.BackColor = Color.White;
                File my_file = new File();
                if (myTree.file_exists(FileName.Text))
                {
                    MessageBox.Show("The file exists already");
                }
                else
                {
                    my_file.Create_File(FileName.Text, "File", DateTime.Today.Date, 0, 0, "Hello People");
                    myTree.Insert(my_file, CurrentFolder.Text);

                }

            }
            Fill_Mytree();
            //Refresh total elements
            totalElements.Text = myTree.get_Count().ToString();    
        }

        










       

        

        private void Filereading_TextChanged(object sender, EventArgs e)
        {

        }


        void DisplayBinaryFile()
        {
            int nCols = 16;
            FileStream inStream = new FileStream(FileView.SelectedNode.FullPath, FileMode.Open,
                                                             FileAccess.Read);
            long nBytesToRead = inStream.Length;
            if (nBytesToRead > 65536 / 4)
                nBytesToRead = 65536 / 4;

            int nLines = (int)(nBytesToRead / nCols) + 1;
            string[] lines = new string[nLines];
            int nBytesRead = 0;

            for (int i = 0; i < nLines; i++)
            {
                StringBuilder nextLine = new StringBuilder();
                nextLine.Capacity = 4 * nCols;

                for (int j = 0; j < nCols; j++)
                {
                    int nextByte = inStream.ReadByte();
                    nBytesRead++;
                    if (nextByte < 0 || nBytesRead > 65536)
                        break;
                    char nextChar = (char)nextByte;
                    if (nextChar < 16)
                        nextLine.Append(" x0" + string.Format("{0,1:X}",
                                                             (int)nextChar));
                    else if
                        (char.IsLetterOrDigit(nextChar) ||
                                              char.IsPunctuation(nextChar))
                        nextLine.Append("  " + nextChar + " ");
                    else
                        nextLine.Append(" x" + string.Format("{0,2:X}",
                                               (int)nextChar));
                }
                lines[i] = nextLine.ToString();
            }
            inStream.Close();
            this.BinaryContent.Lines = lines;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                
          
        }

        private void BinaryContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalElements.Text = myTree.get_Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Get_current_Folder()
        {
            string[] split = Currentlocation.Text.Split(new Char[] { '\\', ':' });

            Stack myfolders = new Stack();
            foreach (string s in split)
            {
                if(s!="")
                myfolders.Push(s);
            }
            if (!myTree.isFolder(myfolders.Peek().ToString()))
            {
                myfolders.Pop();
            }
            CurrentFolder.Text = myfolders.Peek().ToString();
        }
        private void Clickme1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("test");
        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
            FileName.BackColor = Color.White;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
            

            string all_nodes = "";
            foreach (Node node in myTree.get_All_Nodes()) // Loop through List with foreach
            {

                string parent = "";
                if (node.Parent == null)
                    parent = "Null";
                else
                    parent = node.Parent.Element.get_Name();
                all_nodes += node.Element.get_Name() + "-" + node.Element.get_Filetype()+ "--"+parent + "\n";
            }
            Filereading.Text = all_nodes;
            FileView.Refresh();
            Fill_Mytree();
            //SpecialTreeNode rootTreeNode = new SpecialTreeNode("Node1");
            //var node2a = new SpecialTreeNode("Node 2a");
            //var node2b = new SpecialTreeNode("Node 2b");
            //var node2c = new SpecialTreeNode("Node 2c");

            //node2a.IsSpecial = true;
            //node2c.IsSpecial = true;

            //rootTreeNode.AddChild(node2a);
            //rootTreeNode.AddChild(node2b);
            //rootTreeNode.AddChild(node2c);

            //var node3ca = new SpecialTreeNode("Node 3ca");
            //node2c.AddChild(node3ca);

            //Console.WriteLine(string.Format("Root has {0} nodes", rootTreeNode.ChildNodes.Count));
            //Filereading.Text += "Root has {0} nodes" + rootTreeNode.ChildNodes.Count + "----------";
            //Console.WriteLine(string.Format("Root has {0} special nodes", rootTreeNode.GetSpecialNodes().Count));
            //Filereading.Text +="Root has {0} special nodes"+ rootTreeNode.GetSpecialNodes().Count + "----------";
            //Console.WriteLine(string.Format("Root has {0} special leaf nodes", rootTreeNode.GetSpecialLeafNodes().Count));
            //Filereading.Text += "Root has {0} special leaf nodes"+rootTreeNode.GetSpecialLeafNodes().Count + "----------";
            //Console.WriteLine(string.Format("Root has {0} leaf nodes", rootTreeNode.GetLeafNodes().Count));
            //Filereading.Text += "Root has {0} leaf nodes"+rootTreeNode.GetLeafNodes().Count + "----------";
            //Console.WriteLine("Press any key to end");
            ////Console.ReadKey();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File my_file = new File();
            if (myTree.file_exists(Foldername.Text))
            {
                MessageBox.Show("The Folder exists already");
            }
            else
            {
                my_file.Create_File(Foldername.Text, "Folder", DateTime.Today.Date, 0, 0, "");
                myTree.Insert(my_file, CurrentFolder.Text);

            }
            Fill_Mytree();
            //Refresh total elements
            totalElements.Text = myTree.get_Count().ToString();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }



        private void Fill_Mytree()
        {

            var paths = new List<string>
                        {
                            @"Root:\",          
                        };
            //var paths = new List<string>
            //            {
            //                @"C:\freedom",
            //                @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727",
            //                @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\MUI",
            //                @"C:\WINDOWS\addins",
            //                @"C:\WINDOWS\AppPatch",
            //                @"C:\WINDOWS\AppPatch\MUI",
            //                @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\MUI\0409"
            //            };
            foreach (Node node in myTree.get_All_Nodes()) // Loop through List with foreach
            {

                string path = "";
                if (node.Parent != null)
                {
                    path = myTree.getFullPath(node);
                }
                if (path != "")
                    paths.Add(path);

                // reset the path
                myTree.resetFilepath();
            }
           
            //FileView.PathSeparator = @"\";
            PopulateTreeView(FileView, paths, '\\');
           
           // populateTree(FileView,paths);
        }

        private static void PopulateTreeView(TreeView treeView, IEnumerable<string> paths, char pathSeparator)
        {
            TreeNode lastNode = null;
            string subPathAgg;
            foreach (string path in paths)
            {
                subPathAgg = string.Empty;
                lastNode = null;
                foreach (string subPath in path.Split(pathSeparator))
                {
                    if (subPath != "")
                    {
                        subPathAgg += subPath + pathSeparator;
                        TreeNode[] nodes = treeView.Nodes.Find(subPathAgg, true);
                        if (nodes.Length == 0)
                            if (lastNode == null)
                                lastNode = treeView.Nodes.Add(subPathAgg, subPath);
                            else
                                lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                        else
                            lastNode = nodes[0];

                    }
                }
            }
        }
        private  void populateTree(TreeView treeView,IEnumerable<string> paths)
        {

            TreeNode root = new TreeNode();
            TreeNode node = root;
            treeView.Nodes.Add(root);

            foreach (string filePath in paths) // myList is your list of paths
            {
                node = root;
                foreach (string pathBits in filePath.Split('\\'))
                {
                    node = AddNode(node, pathBits);
                }
            }
        }
        private TreeNode AddNode(TreeNode node, string key)
        {
            if (node.Nodes.ContainsKey(key))
            {
                return node.Nodes[key];
            }
            else
            {
                return node.Nodes.Add(key, key);
            }
        }
        private void CurrentFolder_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FileView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //CurrentFolder.Text = FileView.SelectedNode.FirstNode.Text;
            Currentlocation.Text = FileView.SelectedNode.FullPath;
            Get_current_Folder();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
