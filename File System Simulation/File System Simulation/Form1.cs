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
        FileSimulator myTree = new FileSimulator();
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
                string fileID ;
                if ( CurrentFolder.Text =="Root:\\")
                    fileID =  CurrentFolder.Text  + FileName.Text;
                else
                    fileID = CurrentFolder.Text  + "\\" + FileName.Text;

                if (myTree.file_exists(fileID))
                {
                    MessageBox.Show("The file exists already");
                }
                else
                {
                    my_file.Create_File(fileID,FileName.Text, "File", DateTime.Today.Date, 0, 0, "Hello People");
                    myTree.Insert(my_file, CurrentFolder.Text);

                }

            }
            Fill_Mytree();
            UpdateStatusbar(); 
        }

        private void Filereading_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStatusbar();
            CurrentFolder.Text = "Root:\\";
        }

        private void UpdateStatusbar()
        {
            totalElements.Text = myTree.get_Count().ToString();
            totalfolders.Text = myTree.getFoldersNumber().ToString();
            totalfiles.Text = myTree.getFilesNumber().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            myTree.preorder_Traversal(myTree.getRootNode());
            MessageBox.Show(myTree.traversal);

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
        private void Get_FolderID()
        {
            if (Currentlocation.Text == "Root:")
                Currentlocation.Text = "Root:\\";
            if (myTree.isFolder(Currentlocation.Text))
            {
                CurrentFolder.Text = Currentlocation.Text;
            }
            else
            {
                CurrentFolder.Text = myTree.getParent(myTree.GetNode(Currentlocation.Text));
            }
            //CurrentFolder.Text = "";
        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
           // FileName.BackColor = Color.White;
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
                all_nodes += node.Element.get_Name() + "-" + node.Element.get_Filetype()+ "--"+parent +"--" + node.Element.get_ID() + "\n";
                string[] row = { node.Element.get_Name(), node.Element.get_Filetype(), node.Element.get_ID()};
                ContentGrid.Rows.Add(row);
            }
            Filereading.Text = all_nodes;
            FileView.Refresh();
            Fill_Mytree();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File my_file = new File();
            string fileID;

            if (CurrentFolder.Text == "Root:\\")
                fileID = CurrentFolder.Text + Foldername.Text;
            else
                fileID = CurrentFolder.Text + "\\" + Foldername.Text;
            if (myTree.file_exists(fileID))
            {
                MessageBox.Show("The Folder exists already");
            }
            else
            {
                
                my_file.Create_File(fileID,Foldername.Text, "Folder", DateTime.Today.Date, 0, 0, "");
                myTree.Insert(my_file, CurrentFolder.Text);

            }
            Fill_Mytree();
            UpdateStatusbar();    
        }


        private void Fill_Mytree()
        {

            var paths = new List<string>
                        {
                            @"Root:\",          
                        };
            
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
           
          
        }

        //Source code for this function was copied from:
        //http://stackoverflow.com/questions/673931/file-system-treeview/674119#674119
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
       
       

        private void FileView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            Currentlocation.Text = FileView.SelectedNode.FullPath;
            Get_FolderID();
        }

        private void button5_Click(object sender, EventArgs e)
        {



            for (int i = 1; i < 100; i++)
            {
                string random = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
                File my_file = new File();
                string fileID = CurrentFolder.Text + "\\" + FileName.Text;
                my_file.Create_File(fileID,random, "File", DateTime.Today.Date, 0, 0, "Hello People");
                myTree.Insert(my_file, CurrentFolder.Text);
            }
            
            Fill_Mytree();
            UpdateStatusbar(); 
        }

        private void create100RandomFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                string random = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
                File my_file = new File();
                //string fileID = CurrentFolder.Text + "\\" + random;
                string fileID;
                if (CurrentFolder.Text == "Root:\\")
                    fileID = CurrentFolder.Text + random;
                else
                    fileID = CurrentFolder.Text + "\\" + random;
                my_file.Create_File(fileID,random, "File", DateTime.Today.Date, 0, 0, "Hello People");
                myTree.Insert(my_file, CurrentFolder.Text);
            }

            Fill_Mytree();
            UpdateStatusbar(); 
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateFiles_Click(sender,e);
        }
        

       
      
    }
}
