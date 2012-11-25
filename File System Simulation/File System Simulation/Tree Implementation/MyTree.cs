using System;
using System.Collections.Generic;

namespace File_System_Simulation
{
    class MyTree
    {
        //private List myTree = new List; 
        private static  List<Node> MyNodes = new List<Node>();
        private Node root;
        private string filepath = "";
        //Constructor
        public MyTree()
        {

            // Create the root of the file system:

            root = new Node();
            File rootFolder = new File();
            rootFolder.Create_File("Root:\\", "Root", "Folder", DateTime.Today.Date, 0, 0, "");
            root.Element = rootFolder;
            root.FirstChild = null;
            root.NextSibling = null;
            root.Parent = null;
            MyNodes.Add(root);
            //root = null;
        }
        public  string traversal = "";
        public int get_Count()
        {
            return MyNodes.Count;
        }
       
        public void preorder_Traversal(Node root)
        {
            //this.root = root;
            if (root != null)
            {
                traversal += root.Element.get_Name() + "-";
                preorder_Traversal(root.FirstChild);

            }
            
        }
        
        
        public void Insert(File Myfile,string ParentID)
        {

            
            Node newNode = new Node();
            newNode.Element = Myfile;
            newNode.FirstChild = null;
            Node parent = MyNodes[get_Index(ParentID)];
            newNode.Parent = parent;
           //Set the connection between the this node and it's parent
            if (parent.FirstChild == null) 
                parent.FirstChild = newNode;
            MyNodes.Add(newNode);


            
        }
        public int get_Index(string fileID)
        {
            int index = -1;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                if (node.Element.get_ID() == fileID)
                {
                    index = MyNodes.IndexOf(node);
                    break;
                }
            }

            return index;
        }
        public int getFoldersNumber()
        {
            int foldersNumber = 0;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                if (node.Element.get_Filetype() == "Folder")
                    foldersNumber++;
            }
            return foldersNumber;
        }
        public int getFilesNumber()
        {
            int foldersNumber = 0;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                if (node.Element.get_Filetype() == "File")
                    foldersNumber++;
            }
            return foldersNumber;
        }
        public Boolean file_exists(string fileID)
        {
            Boolean exists =true;
            if (get_Index(fileID) == -1)
            {
                exists = false;
            }

            return exists;

        }
        public Node GetNode(string fileID)
        {
            Node returned_Node = null;
            foreach (Node node in MyNodes) // Loop through List with foreach
            {
                if (node.Element.get_ID() == fileID)
                {
                    returned_Node = node;
                    break;
                }
            }

            return returned_Node;
        }
        public Node getRootNode()
        {
            return root;
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

        public Boolean isFolder(string fileID)
        {
            Boolean isfolder= false;
            if(MyNodes[get_Index(fileID)].Element.get_Filetype() == "Folder")
            {
                isfolder= true;
            }
            return isfolder;
        }
         
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
        public string getParent(Node node)
        {

            return node.Parent.Element.get_ID();
        }
    }
}
