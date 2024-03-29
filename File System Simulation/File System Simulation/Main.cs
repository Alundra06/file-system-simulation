﻿using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace File_System_Simulation
{
    public partial class Main : Form
    {
        //Initiate the tree data structure
        FileSimulator myTree = new FileSimulator();
        public Main()
        {
            
            InitializeComponent();
            Fill_Mytree();

        }
        private void CreateFiles_Click(object sender, EventArgs e)
        {
            if (FileName.Text.Length == 0)
            {
                MessageBox.Show("Please insert a valid file name");
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
                    int i = Convert.ToInt32(FileSize.Text);
                    int j = myTree.getDiskBlockSize();
                    int result;
                    int quotient = Math.DivRem(i, j, out result);
                    if (result==0)
                        i = quotient;
                    else
                        i = quotient + 1;
                    //Check if we have enough blocks on the disk
                    if (i > myTree.getFreeBlocks())
                        MessageBox.Show("Disk is full please remove some files first");
                    else
                    {
                        List<int> freeBlocks = myTree.getContiguousFreeblocks(i);
                        if (freeBlocks.Count < i )//Check if the returned free blocks are smaller than the contiguous block needed.
                            MessageBox.Show("Cannot allocate contiguous blocks for your file");
                        else
                        {
                            my_file.Create_File(fileID, FileName.Text, "File", DateTime.Today.Date, Convert.ToDouble(FileSize.Text), freeBlocks[0], i);
                            //Create random data to add to the file:
                            string randomFileData = System.IO.Path.GetRandomFileName();
                            myTree.Insert(my_file, CurrentFolder.Text, randomFileData);
                        }
                    }

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
            diskSpace.Text = myTree.getDiskSize().ToString();
            freedDiskSpace.Text = myTree.getFreeSpace().ToString();
            blockSize.Text = myTree.get_blockSize().ToString();
            displayDiskBlocks();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
           // myTree.preorder_Traversal(myTree.getRootNode());
            //MessageBox.Show(myTree.traversal);

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
            MessageBox.Show(myTree.GetNode(Currentlocation.Text).NextSibling.Element.get_Name().ToString());
            //Filereading.Text = all_nodes;
            //FileView.Refresh();
            //Fill_Mytree();
            //string parent = "";
            //if (node.Parent == null)
            //    parent = "Null";
            //else
            //    parent = node.Parent.Element.get_Name();
            //all_nodes += node.Element.get_Name() + "-" + node.Element.get_Filetype() + "--" + parent + "--" + node.Element.get_ID() + "\n";
            //string[] row = { node.Element.get_Name(), node.Element.get_Filetype(), node.Element.get_ID() };
            //ContentGrid.Rows.Add(row);


        }
        private void displayDiskBlocks()
        {
            ContentGrid.Rows.Clear();
            int i = 0;
            //string all_nodes = "";
            foreach (Block block in myTree.getAllBlocks()) // Loop through List with foreach
            {
                string[] row = { i.ToString(), block.getCurrentStatus().ToString(), block.getData() };
                ContentGrid.Rows.Add(row);
                i++;
            }
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
                
                my_file.Create_File(fileID,Foldername.Text, "Folder", DateTime.Today.Date,0, -1, 0);
                myTree.Insert(my_file, CurrentFolder.Text,"");

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

            for (int n = 0; n < ContentGrid.RowCount; n++)
            {
                ContentGrid.Rows[n].DefaultCellStyle.BackColor = Color.White;
            }
            Currentlocation.Text = FileView.SelectedNode.FullPath;
            Get_FolderID();

            // Get the content of the file:
            int firstBlock = myTree.GetNode(Currentlocation.Text).Element.getFirstBlock();
            int numberBlocks = myTree.GetNode(Currentlocation.Text).Element.getNumberofBlocks();
            Filereading.Text = myTree.getFileData(firstBlock, numberBlocks);
            //Get the file size
            lFileSize.Text = myTree.GetNode(Currentlocation.Text).Element.getFileSize().ToString();

            //change the color of the reserved blocks
            int k = myTree.GetNode(Currentlocation.Text).Element.getFirstBlock();
            int j = myTree.GetNode(Currentlocation.Text).Element.getNumberofBlocks();
            for (int i = 0; i < j; i++)
            {
                ContentGrid.Rows[k].DefaultCellStyle.BackColor = Color.GreenYellow;
                k++;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {



            //for (int i = 1; i < 100; i++)
            //{
            //    string random = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
            //    File my_file = new File();
            //    string fileID = CurrentFolder.Text + "\\" + FileName.Text;
            //    my_file.Create_File(fileID,random, "File", DateTime.Today.Date);
            //    myTree.Insert(my_file, CurrentFolder.Text);
            //}
            
            //Fill_Mytree();
            //UpdateStatusbar(); 
        }
        private void create100RandomFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random randomSize = new Random();
            for (int ii = 1; ii <= 10; ii++)
            {

                
                string randomFileName = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
                File my_file = new File();
                string fileID;
                if (CurrentFolder.Text == "Root:\\")
                    fileID = CurrentFolder.Text + randomFileName;
                else
                    fileID = CurrentFolder.Text + "\\" + randomFileName;

                if (myTree.file_exists(fileID))
                {
                    MessageBox.Show("The file exists already");
                }
                else
                {
                    int randomFileSize = randomSize.Next(Setup.DiskBlock*10)+1;
                    
                    //MessageBox.Show(randomFileSize.ToString());
                    int i = randomFileSize;
                    int j = myTree.getDiskBlockSize();
                    int result;
                    int quotient = Math.DivRem(i, j, out result);
                    if (result == 0)
                        i = quotient;
                    else
                        i = quotient + 1;
                    //Check if we have enough blocks on the disk
                    if (i > myTree.getFreeBlocks())
                        MessageBox.Show("Disk is full please remove some files first");
                    else
                    {
                        List<int> freeBlocks = myTree.getContiguousFreeblocks(i);
                        if (freeBlocks.Count < i)//Check if the returned free blocks are smaller than the contiguous block needed.
                            MessageBox.Show("Cannot allocate contiguous blocks for your file");
                        else
                        {
                            my_file.Create_File(fileID, randomFileName, "File", DateTime.Today.Date, Convert.ToDouble(randomFileSize), freeBlocks[0], i);
                            //Create random data to add to the file:
                            string randomFileData = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
                            myTree.Insert(my_file, CurrentFolder.Text, randomFileData);
                        }
                    }
                }




            }
            Fill_Mytree();
            UpdateStatusbar();
        }
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateFiles_Click(sender,e);
        }
        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ContentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DeleteFiles_Click(object sender, EventArgs e)
        {
            if (myTree.GetNode(Currentlocation.Text).Element.get_Filetype() == "File")
            {
                myTree.deleteFile(myTree.GetNode(Currentlocation.Text));
                UpdateStatusbar();
                FileView.Nodes.Clear();
                Fill_Mytree();
                FileView.CollapseAll();
            }
            else
            {
                MessageBox.Show("Please select a valid file");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (CurrentFolder.Text == "Root:\\")
                MessageBox.Show("You cannot delete the root");
            else
            {
                if (myTree.GetNode(Currentlocation.Text).Element.get_Filetype() == "Folder")
                {
                    myTree.deleteFolder(myTree.GetNode(CurrentFolder.Text));
                    UpdateStatusbar();
                    FileView.Nodes.Clear();
                    Fill_Mytree();
                    FileView.CollapseAll();
                }
                else
                {
                    MessageBox.Show("Please select a valid folder");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create100RandomFilesToolStripMenuItem_Click(sender, e);
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
