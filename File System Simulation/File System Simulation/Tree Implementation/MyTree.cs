using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_System_Simulation
{
    class MyTree
    {
        //private List myTree = new List; 
        private static  List<Node> MyNodes = new List<Node>();
        private Node root;
        public int get_Count()
        {
            return MyNodes.Count;
        }
        public MyTree()
        {
            
            // Create the root of the file system:
            
            root = new Node();
            File rootFolder = new File();
            rootFolder.Create_File("Root", "Folder", DateTime.Today.Date, 0, 0, "");
            root.Element = rootFolder;
            root.FirstChild = null;
            root.NextSibling = null;
            root.Parent = null;
            MyNodes.Add(root);
            //root = null;
        }
        public void Insert(File Myfile,string ParentFolder)
        {

            
            Node newNode = new Node();
            newNode.Element = Myfile;
            newNode.FirstChild = null;
            newNode.Parent = MyNodes[get_Index(ParentFolder)];
           //check if the parent node is set already or not
            if (MyNodes[get_Index(ParentFolder)].FirstChild == null) 
                MyNodes[get_Index(ParentFolder)].FirstChild = newNode;
            MyNodes.Add(newNode);

            
        }
        public int get_Index(string myfile)
        {
            int index = -1;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                if (node.Element.get_Name() == myfile)
                {
                    index = MyNodes.IndexOf(node);
                    break;
                }
            }
            return index;
        }

        public Boolean file_exists(string filename)
        {
            Boolean exists =true;
            if (get_Index(filename) == -1)
            {
                exists = false;
            }

            return exists;

        }
        public File GetNode()
        {
            Node returned_Node = null;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                returned_Node = node;
            }
            return returned_Node.Element;
        }
        public List<Node> get_All_Nodes()
        {
            return MyNodes;
        }
        public Boolean hasChildren(Node node)
        {
            if (node.FirstChild == null)
                return true;
            else 
                return false;

        }

        public Boolean isFolder(string foldername)
        {
            Boolean isfolder= false;
            if(MyNodes[get_Index(foldername)].Element.get_Filetype() == "Folder")
            {
                isfolder= true;
            }
            return isfolder;
        }
         private string filepath = "";
         public void resetFilepath()
         {
             filepath = "";
         }
        public string getFullPath(Node node)
        {

            if (node.Parent != null)
            {
                filepath = node.Element.get_Name() + @"\" + filepath;
                getFullPath(node.Parent);
            }
            else
            {
                filepath = node.Element.get_Name() + @":\" + filepath;
            }

            return filepath;

        }
    }
}
