using System;
using System.Collections.Generic;

namespace File_System_Simulation
{
    class FileSimulator
    {
        //Implementation of the "first-Child-Next-sibling tree
        private static  List<Node> MyNodes = new List<Node>();
        private static int diskSize = Setup.DiskSize;
        private static int diskBlock = Setup.DiskBlock;
       // private static  List<DiskBlocks> myDisk = new List<DiskBlocks>(diskSize/diskBlock);
        private static DiskBlocks myDisk = new DiskBlocks(diskSize, diskBlock);
        //The root node
        private Node root;
        private string filepath = "";
        private Node lastNode = null;
        private Node previousNode = null;
        private Node tempNode = null;
        //Constructor
        public FileSimulator()
        {

            // Create the root of the file system:

            root = new Node();
            File rootFolder = new File();
            rootFolder.Create_File("Root:\\", "Root", "Folder", DateTime.Today.Date,0,-1,0);
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
        public int get_blockSize()
        {
            return diskBlock;
        }
        public void preorder_Traversal(Node root)
        {
            root = this.root ;
            if (root != null)
            {
                traversal += root.Element.get_Name() + "-";
                preorder_Traversal(root.FirstChild);

            }
            
        }
        public void Insert(File Myfile,string ParentID,string fileData)
        {

            
            Node newNode = new Node();
            newNode.Element = Myfile;
            newNode.FirstChild = null;
            newNode.NextSibling = null;
            Node parent = MyNodes[get_Index(ParentID)];
            newNode.Parent = parent;
            //if the parent does have at least a child please adjust the siblings
            if (parent.FirstChild != null)
                getLastSibling(parent.FirstChild).NextSibling = newNode;
           //Set the connection between the this node and it's parent
            else //if (parent.FirstChild == null) 
                parent.FirstChild = newNode;

            MyNodes.Add(newNode);
            if(Myfile.get_Filetype() == "File")
            myDisk.writeContiguousDataToBlocks(Myfile.getFirstBlock(), Myfile.getNumberofBlocks(), fileData,false);            
        }
        public void deleteFile(Node myfile)
        {
            //delete Data first from the disk
            myDisk.writeContiguousDataToBlocks(myfile.Element.getFirstBlock(), myfile.Element.getNumberofBlocks(),string.Empty,true);
            //remap the tress
            relocateRemovedSibling(myfile);
            MyNodes.Remove(myfile);
        }
        private void removeSubFolders(Node myFolder)
        {
            if (myFolder.FirstChild != null)
            {
                if (myFolder.FirstChild.FirstChild != null)
                {
                    removeSubFolders(myFolder.FirstChild);
                }
                else
                {
                    deleteFile(myFolder.FirstChild);
                    removeSubFolders(myFolder);
                }
            }
            else
            {
                //check if the current node is the first node calling the function
                if (myFolder != tempNode)
                {
                    Node mynode = myFolder;
                    deleteFile(myFolder);
                    removeSubFolders(mynode.Parent);
                }
            }

        }

        
        public void deleteFolder(Node myFolder)
        {
            if (myFolder.FirstChild == null) //if the folder doesn't have subfolders
            {
                if (myFolder.NextSibling == null)
                    myFolder.Parent.FirstChild = null;
                else
                {
                    myFolder.Parent.FirstChild = myFolder.NextSibling;
                }
                
            }
            else //if the folder has  subfolders
            {
                tempNode = myFolder;
                removeSubFolders(myFolder);
            }
            
            //delete the folder after deleting all the sublings
            deleteFile(myFolder);

           
        }
        private Node getLastSibling(Node childNode)
        {
            //Node lastSibling=null;
            if (childNode.NextSibling != null)
            {
                getLastSibling(childNode.NextSibling);
            }
            else
            {
                lastNode = childNode;
            }
            return lastNode;
         
        }
        private Node getPreviousSibling(Node firstChildNode,Node MyNode)
        {
            if (firstChildNode.NextSibling != MyNode)
            {
                getPreviousSibling(firstChildNode.NextSibling,MyNode);
            }
            else
            {
                previousNode = firstChildNode;
            }
            return previousNode;

        }
        private void relocateRemovedSibling(Node myNode)
        {
            //Check if the node is the first child
            if (myNode == myNode.Parent.FirstChild)
            {
                //check if the node has a sibling
                if (myNode.NextSibling == null)
                    myNode.Parent.FirstChild = null;//If No remove the first child from th eparent
                else
                    myNode.Parent.FirstChild = myNode.NextSibling;//if Yes change the first child to the next sibling
            }
            else //If it's not the first child
            {
                //check if it's has NO sibling
                if (myNode.NextSibling == null)
                    //Make the previous node nextchild=NULL
                    getPreviousSibling(myNode.Parent.FirstChild, myNode).NextSibling = null;
                else
                    getPreviousSibling(myNode.Parent.FirstChild, myNode).NextSibling = myNode.NextSibling;

            }

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
        public Node get_Index(Node myNode,String name)
        {
            

            return myNode;
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
        ///////Disk Simulator methods calls//////////////////
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        /// <returns></returns>
        public int getDiskBlockSize()
        {
            return myDisk.getBlockSize();
        }
        public List<int> getContiguousFreeblocks(int numberOfBlocks)
        {
            return myDisk.getContiguousFreeblocks(numberOfBlocks);
        }
        public int getDiskSize()
        {
            return myDisk.getDiskSize();
        }
        public int getFreeSpace()
        {
            return myDisk.getFreeSpace();
        }
        public int getFreeBlocks()
        {
            return myDisk.getFreeBlocks();
        }
        public string getFileData(int firstBlock, int blocksNumber)
        {
            return myDisk.getFileData(firstBlock,blocksNumber);
        }
        public List<Block> getAllBlocks()
        {
            return myDisk.getAllBlocks();
        }


    }
}
