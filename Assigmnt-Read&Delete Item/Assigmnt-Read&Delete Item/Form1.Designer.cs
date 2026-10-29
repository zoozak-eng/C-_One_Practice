namespace Assigmnt_Read_Delete_Item
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
            this.listBoxDisblay = new System.Windows.Forms.ListBox();
            this.btnCraetFile = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeanth = new System.Windows.Forms.Button();
            this.btnEndAsync = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDisblay
            // 
            this.listBoxDisblay.FormattingEnabled = true;
            this.listBoxDisblay.ItemHeight = 20;
            this.listBoxDisblay.Location = new System.Drawing.Point(557, 25);
            this.listBoxDisblay.Name = "listBoxDisblay";
            this.listBoxDisblay.Size = new System.Drawing.Size(538, 564);
            this.listBoxDisblay.TabIndex = 0;
            // 
            // btnCraetFile
            // 
            this.btnCraetFile.Location = new System.Drawing.Point(31, 25);
            this.btnCraetFile.Name = "btnCraetFile";
            this.btnCraetFile.Size = new System.Drawing.Size(202, 100);
            this.btnCraetFile.TabIndex = 1;
            this.btnCraetFile.Text = "Creating New File";
            this.btnCraetFile.UseVisualStyleBackColor = true;
            this.btnCraetFile.Click += new System.EventHandler(this.btnCraetFile_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(252, 25);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(202, 100);
            this.btnPeek.TabIndex = 2;
            this.btnPeek.Text = "Read Using Peek()";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Read Using Peek() \r\nAnother Way";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeanth
            // 
            this.btnLeanth.Location = new System.Drawing.Point(252, 148);
            this.btnLeanth.Name = "btnLeanth";
            this.btnLeanth.Size = new System.Drawing.Size(202, 100);
            this.btnLeanth.TabIndex = 4;
            this.btnLeanth.Text = "Reading Leanth\r\n Of The FIle";
            this.btnLeanth.UseVisualStyleBackColor = true;
            this.btnLeanth.Click += new System.EventHandler(this.btnLeanth_Click);
            // 
            // btnEndAsync
            // 
            this.btnEndAsync.Location = new System.Drawing.Point(142, 267);
            this.btnEndAsync.Name = "btnEndAsync";
            this.btnEndAsync.Size = new System.Drawing.Size(203, 99);
            this.btnEndAsync.TabIndex = 5;
            this.btnEndAsync.Text = "ReadToEndAsync()";
            this.btnEndAsync.UseVisualStyleBackColor = true;
            this.btnEndAsync.Click += new System.EventHandler(this.btnEndAsync_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 104);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete File";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(280, 402);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(205, 104);
            this.btnDeleteFolder.TabIndex = 7;
            this.btnDeleteFolder.Text = "Delete Folder";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 638);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEndAsync);
            this.Controls.Add(this.btnLeanth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnCraetFile);
            this.Controls.Add(this.listBoxDisblay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisblay;
        private System.Windows.Forms.Button btnCraetFile;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeanth;
        private System.Windows.Forms.Button btnEndAsync;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteFolder;
    }
}

