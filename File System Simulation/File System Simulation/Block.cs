using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_System_Simulation
{
    class Block
    {
        private string data;
        private Boolean currentBlockStatus;
        public  Block()
        {
            currentBlockStatus = true;
            data = string.Empty;
        }
        public string getData()
        {
            return this.data;
        }
        public Boolean getCurrentStatus()
        {
            return this.currentBlockStatus;
        }
        public void setData(string data)
        {
            this.data = data;
        }
        public void setCurrentStatus(Boolean status)
        {
            this.currentBlockStatus=status;
        }
    }
}
