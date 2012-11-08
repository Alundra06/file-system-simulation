using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace File_System_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Fill the tree drives mapping
            try
            {
                FileView.Nodes.Clear();
                fillTree();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          

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
            try
            {
                string Path = CurrentFolder.Text;
                string fileName = Path + FileName.Text;
                FileStream fstPersons = new FileStream(fileName, FileMode.Create);
                BinaryWriter wrtPersons = new BinaryWriter(fstPersons);
                wrtPersons.Write("James Bloch");
                wrtPersons.Write("Catherina Wallace");
                wrtPersons.Write("Bruce Lamont");
                wrtPersons.Write("Douglas Truth");
                wrtPersons.Close();
                fstPersons.Close();
              //////////////////////////////////
              //////////////////////////////////
              /// Refresh the Treeview://///////
              /// /////////////////////////////
              /////////////////////////////////
                try
                {
                    FileView.Nodes.Clear();
                    fillTree();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
            }
        }

        private void fillTree()
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string dr in drives)
            {
                TreeNode node = new TreeNode(dr);
                node.Tag = dr;
                node.ImageIndex = 0; // drive icon
                node.Tag = dr;
                FileView.Nodes.Add(node);
                node.Nodes.Add(new TreeNode("?"));
            }
            FileView.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
        }

        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count == 1) && (e.Node.Nodes[0].Text == "?"))
            {
                RecursiveDirWalk(e.Node);
            }
        }

        private TreeNode RecursiveDirWalk(TreeNode node)
        {
            string path = (string)node.Tag;
            node.Nodes.Clear();
           
            try
            {
                string[] dirs = System.IO.Directory.GetDirectories(path);
                for (int t = 0; t < dirs.Length; t++)
                {
                    TreeNode n = new TreeNode(dirs[t].Substring(dirs[t].LastIndexOf('\\') + 1));
                    n.ImageIndex = 1; // dir icon
                    n.Tag = dirs[t];
                    node.Nodes.Add(n);
                    n.Nodes.Add(new TreeNode("?"));
                }

                // Optional if you want files as well:
                string[] files = System.IO.Directory.GetFiles(path);
                for (int t = 0; t < files.Length; t++)
                {
                    TreeNode tn = new TreeNode(System.IO.Path.GetFileName(files[t]));
                    tn.Tag = files[t];
                    tn.ImageIndex = 2; // file icon
                    node.Nodes.Add(tn);
                } // end of optional file part
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            

            return node;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                CurrentFolder.Text = FileView.SelectedNode.FullPath;
                FileStream fleReader = new FileStream(FileView.SelectedNode.FullPath, FileMode.Open, FileAccess.Read);
                StreamReader stmReader = new StreamReader(fleReader);
                StringBuilder lstChars = new StringBuilder();

                int iChar = stmReader.Read();
                lstChars.Append((char)iChar);
                while (iChar > -1)
                {
                    iChar = stmReader.Read();
                    lstChars.Append((char)iChar);
                }

                this.Filereading.Text = lstChars.ToString();
                stmReader.Close();
                fleReader.Close();
            }
            catch (System.Exception ex)
            {
               // MessageBox.Show(ex.Message.ToString());
            }

            try
            {
                DisplayBinaryFile();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
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
            string path = CurrentFolder.Text;
            // Delete the file if it exists. 
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
             //////////////////////////////////
              //////////////////////////////////
              /// Refresh the Treeview://///////
              /// /////////////////////////////
              /////////////////////////////////
                try
                {
                    FileView.Nodes.Clear();
                    fillTree();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
          
        }

        private void BinaryContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

             

    
    }
}
