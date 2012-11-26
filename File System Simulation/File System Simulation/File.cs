using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace File_System_Simulation
{
    class File 

    {
        private string ID;//to hold the unique ID of the file (The full path)
        private string Name;
        private string type;//Folder or file
        private DateTime DateOfCreation;
        private double size;
        //private string content;
        //Save the first block and number of the blocks for the disk allocation table
        private int firstBlock;
        private int numberBlocks;

        public File(
            string ID,
            string fileName,
            string fileType,
            DateTime dateofCreation,
            double filesize,
            int firstBlock,
            int numberBlocks
            )
        {
            this.ID = ID;
            this.Name = fileName;
            this.size = filesize;
            this.DateOfCreation = dateofCreation;
            this.firstBlock = firstBlock;
            this.numberBlocks = numberBlocks;
            this.type = fileType;

        }
        public File()
        {


        }

        public void Create_File(

            string ID,
            string fileName,
            string fileType,
            DateTime dateofCreation,
            double filesize,
            int firstBlock,
            int numberBlocks
            )
        {
            this.ID = ID;
            this.Name = fileName;
            this.size = filesize;
            this.DateOfCreation = dateofCreation;
            this.firstBlock = firstBlock;
            this.numberBlocks = numberBlocks;
            this.type = fileType;

        }

        public string get_Name()
        {
            return this.Name;
        }
        public string get_Filetype()
        {
            return this.type;
        }
        public string get_ID()
        {
            return this.ID;
        }
        //public string get_FileContent()
        //{
        //    return this.content;
        //}
        public int getFirstBlock()
        {
            return this.firstBlock;
        }
        public int getNumberofBlocks()
        {
            return this.numberBlocks;
        }
        
    }
}
