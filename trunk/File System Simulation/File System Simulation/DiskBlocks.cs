using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_System_Simulation
{
    class DiskBlocks
    {
        private int diskSize ;
        private int blockSize;
        private List<Block> diskBlock;
        public  DiskBlocks(int diskSize, int blockSize)
        {
            this.blockSize = blockSize;
            this.diskSize = diskSize;
            diskBlock = new List<Block>(diskSize / blockSize);

            for (int i = 0; i < diskBlock.Capacity; i++)
            {
                Block myblock = new Block();
                diskBlock.Add(myblock);
            }



        }
        public int getBlockSize()
        {
            return this.blockSize;
        }
        public int getDiskSize()
        {
            return this.diskSize;
        }
        public void setBlockSize(int blockSize)
        {
            this.blockSize = blockSize;
        }
        public int getFreeSpace()
        {
            int j = 0;
            for (int i = 0; i < diskBlock.Capacity; i++)
            {
                if (diskBlock[i].getCurrentStatus() == true)
                    j++;
                
            }
            return j*blockSize;
        }
        public int getFreeBlocks()
        {
            int j = 0;
            for (int i = 0; i < diskBlock.Capacity; i++)
            {
                if (diskBlock[i].getCurrentStatus() == true)
                    j++;

            }
            return j ;
        }
        public List<Block> getAllBlocks()
        {
            return diskBlock;
        }
        public string getFileData(int firstBlock, int blocksNumber)
        {
            string Mydatafile=string.Empty;
            for (int i = 1; i <= blocksNumber; i++)
            {
                Mydatafile+=diskBlock[firstBlock].getData();
                firstBlock++;
            }
            return Mydatafile;
        }
        public List<int>  getContiguousFreeblocks(int numberOfBlocks)
        {
            //to hold the list of indexes
            List<int> availableBlocks= new List<int>(numberOfBlocks);

            int blocksCount=0; //to count the number of available blocks
            int firstBlock = 0;
            int index=0;
            Boolean changeFirstblock = true;
            for(int i=0;i<diskBlock.Capacity;i++)
            {

                if (diskBlock[i].getCurrentStatus()== true)
                {
                    blocksCount++;
                    if (changeFirstblock)
                    {
                        firstBlock = index;
                        changeFirstblock = false;
                    }
                    availableBlocks.Add(index);
                    if(blocksCount>=numberOfBlocks)
                    break;
                }
                else
                {
                    changeFirstblock = true;
                    availableBlocks.Clear();
                }
                
                index++;
            }


            return availableBlocks;
        }
        public void writeContiguousDataToBlocks(int firstBlock, int blocksNumber,string data,Boolean type)
        {
            for (int i = 1; i <= blocksNumber;i++ )
            {
                diskBlock[firstBlock].setData(data);
                diskBlock[firstBlock].setCurrentStatus(type);
                firstBlock++;
            }
        }
    }
}
