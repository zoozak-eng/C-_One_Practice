namespace Calculate_the_weight
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBoxDisblay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(319, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(460, 26);
            this.txtname.TabIndex = 0;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(319, 78);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(460, 26);
            this.txtweight.TabIndex = 1;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(319, 123);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(460, 26);
            this.txtheight.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(134, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(179, 23);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Enter your name:";
            // 
            // lblweight
            // 
            this.lblweight.Location = new System.Drawing.Point(134, 78);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(149, 23);
            this.lblweight.TabIndex = 4;
            this.lblweight.Text = "Enter your weight:";
            // 
            // lblheight
            // 
            this.lblheight.Location = new System.Drawing.Point(134, 126);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(149, 23);
            this.lblheight.TabIndex = 5;
            this.lblheight.Text = "Enter your Height:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(223, 179);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(189, 70);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(470, 179);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(189, 70);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listBoxDisblay
            // 
            this.listBoxDisblay.FormattingEnabled = true;
            this.listBoxDisblay.ItemHeight = 20;
            this.listBoxDisblay.Location = new System.Drawing.Point(202, 269);
            this.listBoxDisblay.Name = "listBoxDisblay";
            this.listBoxDisblay.Size = new System.Drawing.Size(484, 224);
            this.listBoxDisblay.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.listBoxDisblay);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBoxDisblay;
    }
}

