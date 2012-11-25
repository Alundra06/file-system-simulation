using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_System_Simulation
{
    class DiskBlocks
    {
        private int diskSize = 0;
        private int blockSize = 0;
        public DiskBlocks(int diskSize, int blockSize)
        {
            this.blockSize = blockSize;
            this.diskSize = diskSize;
        }
    }
}
