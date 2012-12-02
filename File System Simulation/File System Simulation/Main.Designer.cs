namespace File_System_Simulation
{
    partial class Main
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
            this.FileView = new System.Windows.Forms.TreeView();
            this.Filereading = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Currentlocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Foldername = new System.Windows.Forms.TextBox();
            this.CurrentFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalElements = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalfolders = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalfiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.diskSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.freedDiskSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.create100RandomFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentGrid = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lFileSize = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.b_Create_Folder = new System.Windows.Forms.Button();
            this.DeleteFiles = new System.Windows.Forms.Button();
            this.CreateFiles = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.blockSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "File System Simulation";
            // 
            // FileView
            // 
            this.FileView.Location = new System.Drawing.Point(177, 89);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(256, 315);
            this.FileView.TabIndex = 1;
            this.FileView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileView_AfterSelect);
            // 
            // Filereading
            // 
            this.Filereading.Location = new System.Drawing.Point(439, 89);
            this.Filereading.Name = "Filereading";
            this.Filereading.Size = new System.Drawing.Size(351, 130);
            this.Filereading.TabIndex = 4;
            this.Filereading.Text = "";
            this.Filereading.TextChanged += new System.EventHandler(this.Filereading_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(220, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tree view of the file system";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(551, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content of the file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(544, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disk blocks status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(128, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current location";
            // 
            // Currentlocation
            // 
            this.Currentlocation.Location = new System.Drawing.Point(260, 410);
            this.Currentlocation.Name = "Currentlocation";
            this.Currentlocation.ReadOnly = true;
            this.Currentlocation.Size = new System.Drawing.Size(173, 20);
            this.Currentlocation.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(15, 137);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(118, 20);
            this.FileName.TabIndex = 13;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // Foldername
            // 
            this.Foldername.Location = new System.Drawing.Point(14, 300);
            this.Foldername.Name = "Foldername";
            this.Foldername.Size = new System.Drawing.Size(119, 20);
            this.Foldername.TabIndex = 16;
            // 
            // CurrentFolder
            // 
            this.CurrentFolder.Location = new System.Drawing.Point(260, 433);
            this.CurrentFolder.Name = "CurrentFolder";
            this.CurrentFolder.ReadOnly = true;
            this.CurrentFolder.Size = new System.Drawing.Size(173, 20);
            this.CurrentFolder.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(128, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Current Folder";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalElements,
            this.toolStripStatusLabel2,
            this.totalfolders,
            this.toolStripStatusLabel3,
            this.totalfiles,
            this.toolStripStatusLabel4,
            this.diskSpace,
            this.toolStripStatusLabel5,
            this.freedDiskSpace,
            this.toolStripStatusLabel6,
            this.blockSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel1.Text = "Total number of elements:";
            // 
            // totalElements
            // 
            this.totalElements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalElements.ForeColor = System.Drawing.Color.Red;
            this.totalElements.Name = "totalElements";
            this.totalElements.Size = new System.Drawing.Size(19, 17);
            this.totalElements.Text = "to";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel2.Text = "Total number of Folders:";
            // 
            // totalfolders
            // 
            this.totalfolders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfolders.ForeColor = System.Drawing.Color.Red;
            this.totalfolders.Name = "totalfolders";
            this.totalfolders.Size = new System.Drawing.Size(19, 17);
            this.totalfolders.Text = "to";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel3.Text = "Total number of Files:";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // totalfiles
            // 
            this.totalfiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfiles.ForeColor = System.Drawing.Color.Red;
            this.totalfiles.Name = "totalfiles";
            this.totalfiles.Size = new System.Drawing.Size(19, 17);
            this.totalfiles.Text = "to";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel4.Text = "Disk Space:";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // diskSpace
            // 
            this.diskSpace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskSpace.ForeColor = System.Drawing.Color.Red;
            this.diskSpace.Name = "diskSpace";
            this.diskSpace.Size = new System.Drawing.Size(19, 17);
            this.diskSpace.Text = "to";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel5.Text = "Free Disk Space:";
            // 
            // freedDiskSpace
            // 
            this.freedDiskSpace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freedDiskSpace.ForeColor = System.Drawing.Color.Red;
            this.freedDiskSpace.Name = "freedDiskSpace";
            this.freedDiskSpace.Size = new System.Drawing.Size(19, 17);
            this.freedDiskSpace.Text = "to";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileToolStripMenuItem,
            this.create100RandomFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.createFileToolStripMenuItem.Text = "Create File";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // create100RandomFilesToolStripMenuItem
            // 
            this.create100RandomFilesToolStripMenuItem.Name = "create100RandomFilesToolStripMenuItem";
            this.create100RandomFilesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.create100RandomFilesToolStripMenuItem.Text = "Create 10 random files";
            this.create100RandomFilesToolStripMenuItem.Click += new System.EventHandler(this.create100RandomFilesToolStripMenuItem_Click);
            // 
            // ContentGrid
            // 
            this.ContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Status,
            this.Data});
            this.ContentGrid.Location = new System.Drawing.Point(439, 271);
            this.ContentGrid.Name = "ContentGrid";
            this.ContentGrid.ReadOnly = true;
            this.ContentGrid.Size = new System.Drawing.Size(351, 301);
            this.ContentGrid.TabIndex = 25;
            this.ContentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContentGrid_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // FileSize
            // 
            this.FileSize.Location = new System.Drawing.Point(57, 159);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(76, 20);
            this.FileSize.TabIndex = 26;
            this.FileSize.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(440, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "File Size:";
            // 
            // lFileSize
            // 
            this.lFileSize.AutoSize = true;
            this.lFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lFileSize.Location = new System.Drawing.Point(512, 222);
            this.lFileSize.Name = "lFileSize";
            this.lFileSize.Size = new System.Drawing.Size(0, 16);
            this.lFileSize.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::File_System_Simulation.Properties.Resources.Folder_Delete_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete folder";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_Create_Folder
            // 
            this.b_Create_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Create_Folder.Image = global::File_System_Simulation.Properties.Resources.folder_close_icon;
            this.b_Create_Folder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Create_Folder.Location = new System.Drawing.Point(12, 260);
            this.b_Create_Folder.Name = "b_Create_Folder";
            this.b_Create_Folder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.b_Create_Folder.Size = new System.Drawing.Size(121, 34);
            this.b_Create_Folder.TabIndex = 15;
            this.b_Create_Folder.Text = "Create folder";
            this.b_Create_Folder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Create_Folder.UseVisualStyleBackColor = true;
            this.b_Create_Folder.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteFiles
            // 
            this.DeleteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFiles.Image = global::File_System_Simulation.Properties.Resources.Button_Delete_icon;
            this.DeleteFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteFiles.Location = new System.Drawing.Point(12, 220);
            this.DeleteFiles.Name = "DeleteFiles";
            this.DeleteFiles.Size = new System.Drawing.Size(121, 34);
            this.DeleteFiles.TabIndex = 9;
            this.DeleteFiles.Text = "Delete file";
            this.DeleteFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteFiles.UseVisualStyleBackColor = true;
            this.DeleteFiles.Click += new System.EventHandler(this.DeleteFiles_Click);
            // 
            // CreateFiles
            // 
            this.CreateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFiles.Image = global::File_System_Simulation.Properties.Resources.Document_icon__1_;
            this.CreateFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateFiles.Location = new System.Drawing.Point(14, 96);
            this.CreateFiles.Name = "CreateFiles";
            this.CreateFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreateFiles.Size = new System.Drawing.Size(119, 34);
            this.CreateFiles.TabIndex = 2;
            this.CreateFiles.Text = "Create file";
            this.CreateFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateFiles.UseVisualStyleBackColor = true;
            this.CreateFiles.Click += new System.EventHandler(this.CreateFiles_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 185);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "10 random files";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel6.Text = "block size:";
            // 
            // blockSize
            // 
            this.blockSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockSize.ForeColor = System.Drawing.Color.Red;
            this.blockSize.Name = "blockSize";
            this.blockSize.Size = new System.Drawing.Size(19, 17);
            this.blockSize.Text = "to";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lFileSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.ContentGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentFolder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Foldername);
            this.Controls.Add(this.b_Create_Folder);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Currentlocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filereading);
            this.Controls.Add(this.CreateFiles);
            this.Controls.Add(this.FileView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "File System Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView FileView;
        private System.Windows.Forms.Button CreateFiles;
        private System.Windows.Forms.RichTextBox Filereading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Currentlocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button b_Create_Folder;
        private System.Windows.Forms.TextBox Foldername;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CurrentFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalElements;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel totalfolders;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel totalfiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem create100RandomFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView ContentGrid;
        private System.Windows.Forms.TextBox FileSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel diskSpace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel freedDiskSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lFileSize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel blockSize;
    }
}

