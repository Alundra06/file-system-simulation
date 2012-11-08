namespace File_System_Simulation
{
    partial class Form1
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
            this.BinaryContent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Foldername = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteFiles = new System.Windows.Forms.Button();
            this.CreateFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "File System Simulation";
            // 
            // FileView
            // 
            this.FileView.Location = new System.Drawing.Point(153, 87);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(302, 315);
            this.FileView.TabIndex = 1;
            this.FileView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Filereading
            // 
            this.Filereading.Location = new System.Drawing.Point(473, 87);
            this.Filereading.Name = "Filereading";
            this.Filereading.Size = new System.Drawing.Size(341, 160);
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
            this.label3.Location = new System.Drawing.Point(585, 71);
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
            this.label4.Location = new System.Drawing.Point(585, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Raw Content";
            // 
            // BinaryContent
            // 
            this.BinaryContent.Location = new System.Drawing.Point(473, 320);
            this.BinaryContent.Name = "BinaryContent";
            this.BinaryContent.ReadOnly = true;
            this.BinaryContent.Size = new System.Drawing.Size(341, 160);
            this.BinaryContent.TabIndex = 7;
            this.BinaryContent.Text = "";
            this.BinaryContent.TextChanged += new System.EventHandler(this.BinaryContent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(220, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current file location";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CurrentFolder
            // 
            this.CurrentFolder.Enabled = false;
            this.CurrentFolder.Location = new System.Drawing.Point(153, 424);
            this.CurrentFolder.Name = "CurrentFolder";
            this.CurrentFolder.Size = new System.Drawing.Size(302, 20);
            this.CurrentFolder.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save Updates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Foldername
            // 
            this.Foldername.Location = new System.Drawing.Point(14, 265);
            this.Foldername.Name = "Foldername";
            this.Foldername.Size = new System.Drawing.Size(119, 20);
            this.Foldername.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::File_System_Simulation.Properties.Resources.Folder_Delete_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete folder";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::File_System_Simulation.Properties.Resources.folder_close_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 225);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(121, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Create folder";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteFiles
            // 
            this.DeleteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFiles.Image = global::File_System_Simulation.Properties.Resources.Button_Delete_icon;
            this.DeleteFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteFiles.Location = new System.Drawing.Point(12, 163);
            this.DeleteFiles.Name = "DeleteFiles";
            this.DeleteFiles.Size = new System.Drawing.Size(121, 34);
            this.DeleteFiles.TabIndex = 9;
            this.DeleteFiles.Text = "Delete file";
            this.DeleteFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteFiles.UseVisualStyleBackColor = true;
            this.DeleteFiles.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 546);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Foldername);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrentFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BinaryContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filereading);
            this.Controls.Add(this.CreateFiles);
            this.Controls.Add(this.FileView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File System Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.RichTextBox BinaryContent;
        private System.Windows.Forms.Button DeleteFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CurrentFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Foldername;
        private System.Windows.Forms.Button button4;
    }
}

