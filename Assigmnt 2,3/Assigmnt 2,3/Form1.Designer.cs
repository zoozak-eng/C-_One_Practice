namespace Assigmnt_2_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnaddcurse = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.listboxcourse = new System.Windows.Forms.ListBox();
            this.listboxdisblay = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblnumberofcourse = new System.Windows.Forms.Label();
            this.txtnumofcourse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information:";
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(12, 130);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(202, 23);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Student Id:";
            // 
            // lblage
            // 
            this.lblage.Location = new System.Drawing.Point(12, 80);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(202, 23);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "Student Age:";
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(12, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(202, 23);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Student Name:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(232, 127);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(241, 26);
            this.txtid.TabIndex = 2;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(232, 80);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 26);
            this.txtage.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(232, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 26);
            this.txtname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnremove);
            this.groupBox2.Controls.Add(this.btnaddcurse);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtcourse);
            this.groupBox2.Controls.Add(this.lblcourse);
            this.groupBox2.Controls.Add(this.lblprice);
            this.groupBox2.Location = new System.Drawing.Point(0, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information:";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(269, 126);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(141, 43);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "&Rimove Courses";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnaddcurse
            // 
            this.btnaddcurse.Location = new System.Drawing.Point(85, 126);
            this.btnaddcurse.Name = "btnaddcurse";
            this.btnaddcurse.Size = new System.Drawing.Size(129, 43);
            this.btnaddcurse.TabIndex = 11;
            this.btnaddcurse.Text = "&Add Course";
            this.btnaddcurse.UseVisualStyleBackColor = true;
            this.btnaddcurse.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(213, 86);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(221, 26);
            this.txtprice.TabIndex = 10;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(213, 43);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(221, 26);
            this.txtcourse.TabIndex = 9;
            // 
            // lblcourse
            // 
            this.lblcourse.Location = new System.Drawing.Point(23, 43);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(154, 23);
            this.lblcourse.TabIndex = 7;
            this.lblcourse.Text = "Corse Name:";
            // 
            // lblprice
            // 
            this.lblprice.Location = new System.Drawing.Point(23, 89);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(154, 23);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Course Price $:";
            // 
            // listboxcourse
            // 
            this.listboxcourse.FormattingEnabled = true;
            this.listboxcourse.ItemHeight = 20;
            this.listboxcourse.Location = new System.Drawing.Point(12, 407);
            this.listboxcourse.Name = "listboxcourse";
            this.listboxcourse.Size = new System.Drawing.Size(467, 204);
            this.listboxcourse.TabIndex = 0;
            // 
            // listboxdisblay
            // 
            this.listboxdisblay.FormattingEnabled = true;
            this.listboxdisblay.ItemHeight = 20;
            this.listboxdisblay.Location = new System.Drawing.Point(485, 12);
            this.listboxdisblay.Name = "listboxdisblay";
            this.listboxdisblay.Size = new System.Drawing.Size(556, 504);
            this.listboxdisblay.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(485, 527);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(189, 73);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(680, 527);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(189, 73);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(873, 527);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(189, 73);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblnumberofcourse
            // 
            this.lblnumberofcourse.Location = new System.Drawing.Point(23, 631);
            this.lblnumberofcourse.Name = "lblnumberofcourse";
            this.lblnumberofcourse.Size = new System.Drawing.Size(230, 23);
            this.lblnumberofcourse.TabIndex = 6;
            this.lblnumberofcourse.Text = "Number Of Registing Courses:";
            this.lblnumberofcourse.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnumofcourse
            // 
            this.txtnumofcourse.Location = new System.Drawing.Point(269, 628);
            this.txtnumofcourse.Name = "txtnumofcourse";
            this.txtnumofcourse.Size = new System.Drawing.Size(100, 26);
            this.txtnumofcourse.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 663);
            this.Controls.Add(this.txtnumofcourse);
            this.Controls.Add(this.lblnumberofcourse);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listboxdisblay);
            this.Controls.Add(this.listboxcourse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxcourse;
        private System.Windows.Forms.ListBox listboxdisblay;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnaddcurse;
        private System.Windows.Forms.Label lblnumberofcourse;
        private System.Windows.Forms.TextBox txtnumofcourse;
    }
}

