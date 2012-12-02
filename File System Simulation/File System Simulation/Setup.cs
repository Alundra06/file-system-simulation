using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File_System_Simulation
{
    public partial class Setup : Form
    {
        public static int DiskSize = 10000;
        public static int DiskBlock = 10;
        public Setup()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            diskSize.Text = trackdiskSize.Value.ToString();
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void trackblockSize_Scroll(object sender, EventArgs e)
        {
            blockSize.Text = trackblockSize.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiskSize = Convert.ToInt32(diskSize.Text);
            DiskBlock = Convert.ToInt32(blockSize.Text);
            Main myMain = new Main();
            myMain.ShowDialog();
            this.Close();
        }
    }
}
