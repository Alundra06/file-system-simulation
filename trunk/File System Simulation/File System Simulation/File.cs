using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace File_System_Simulation
{
    class File 

    {
        private string Name;
        private string type;
        private DateTime DateOfCreation;
        private double size;
        private int Datalink;
        private string content;

        public File(
            string fileName,
            string fileType,
            DateTime dateofCreation,
            double filesize,
            int fileDataLink,
            string fileContent
            )
        {
            this.Name = fileName;
            this.size = filesize;
            this.DateOfCreation = dateofCreation;
            this.Datalink = fileDataLink;
            this.content = fileContent;
            this.type = fileType;

        }
        public File()
        {


        }

        public void Create_File(
            
            string fileName,
            string fileType,
            DateTime dateofCreation,
            double filesize,
            int fileDataLink,
            string fileContent
            )
        {
            this.Name = fileName;
            this.size = filesize;
            this.DateOfCreation = dateofCreation;
            this.Datalink = fileDataLink;
            this.content = fileContent;
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

    }
}
