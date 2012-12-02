namespace File_System_Simulation
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackdiskSize = new System.Windows.Forms.TrackBar();
            this.diskSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackblockSize = new System.Windows.Forms.TrackBar();
            this.blockSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackdiskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackblockSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "File System Simulation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(25, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Disk Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Block Size:";
            // 
            // trackdiskSize
            // 
            this.trackdiskSize.LargeChange = 1000;
            this.trackdiskSize.Location = new System.Drawing.Point(108, 97);
            this.trackdiskSize.Maximum = 1000000;
            this.trackdiskSize.Minimum = 1000;
            this.trackdiskSize.Name = "trackdiskSize";
            this.trackdiskSize.Size = new System.Drawing.Size(268, 45);
            this.trackdiskSize.TabIndex = 31;
            this.trackdiskSize.TickFrequency = 10000;
            this.trackdiskSize.Value = 1000;
            this.trackdiskSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // diskSize
            // 
            this.diskSize.Location = new System.Drawing.Point(382, 100);
            this.diskSize.Name = "diskSize";
            this.diskSize.Size = new System.Drawing.Size(78, 20);
            this.diskSize.TabIndex = 33;
            this.diskSize.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Byte";
            // 
            // trackblockSize
            // 
            this.trackblockSize.LargeChange = 10;
            this.trackblockSize.Location = new System.Drawing.Point(108, 148);
            this.trackblockSize.Maximum = 1000;
            this.trackblockSize.Minimum = 10;
            this.trackblockSize.Name = "trackblockSize";
            this.trackblockSize.Size = new System.Drawing.Size(268, 45);
            this.trackblockSize.TabIndex = 35;
            this.trackblockSize.TickFrequency = 10;
            this.trackblockSize.Value = 10;
            this.trackblockSize.Scroll += new System.EventHandler(this.trackblockSize_Scroll);
            // 
            // blockSize
            // 
            this.blockSize.Location = new System.Drawing.Point(382, 148);
            this.blockSize.Name = "blockSize";
            this.blockSize.Size = new System.Drawing.Size(78, 20);
            this.blockSize.TabIndex = 36;
            this.blockSize.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Byte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(215, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Initial setup";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blockSize);
            this.Controls.Add(this.trackblockSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diskSize);
            this.Controls.Add(this.trackdiskSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackdiskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackblockSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackdiskSize;
        private System.Windows.Forms.TextBox diskSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackblockSize;
        private System.Windows.Forms.TextBox blockSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}