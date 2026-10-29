namespace assingment1
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
            this.components = new System.ComponentModel.Container();
            this.txtname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtdebartment = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldebartment = new System.Windows.Forms.Label();
            this.lblsemeter = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(377, 89);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(246, 26);
            this.txtname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Location = new System.Drawing.Point(377, 135);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(246, 26);
            this.txtstudentid.TabIndex = 2;
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Location = new System.Drawing.Point(377, 226);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(246, 26);
            this.txtsemester.TabIndex = 3;
            // 
            // txtdebartment
            // 
            this.txtdebartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdebartment.Location = new System.Drawing.Point(377, 180);
            this.txtdebartment.Name = "txtdebartment";
            this.txtdebartment.Size = new System.Drawing.Size(246, 26);
            this.txtdebartment.TabIndex = 4;
            // 
            // lblstudentname
            // 
            this.lblstudentname.Location = new System.Drawing.Point(122, 89);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(249, 23);
            this.lblstudentname.TabIndex = 5;
            this.lblstudentname.Text = "ENTER STUDENT NAME:";
            this.lblstudentname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.Location = new System.Drawing.Point(122, 135);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(223, 26);
            this.lblstudentid.TabIndex = 6;
            this.lblstudentid.Text = "ENTER STUDENT ID:";
            // 
            // lbldebartment
            // 
            this.lbldebartment.Location = new System.Drawing.Point(122, 180);
            this.lbldebartment.Name = "lbldebartment";
            this.lbldebartment.Size = new System.Drawing.Size(195, 26);
            this.lbldebartment.TabIndex = 7;
            this.lbldebartment.Text = "ENTER DEBARTMENT:";
            // 
            // lblsemeter
            // 
            this.lblsemeter.Location = new System.Drawing.Point(122, 226);
            this.lblsemeter.Name = "lblsemeter";
            this.lblsemeter.Size = new System.Drawing.Size(199, 23);
            this.lblsemeter.TabIndex = 8;
            this.lblsemeter.Text = "ENTER SEMESTER:";
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(168, 363);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(191, 53);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "SHOW INFO.";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(377, 363);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(196, 53);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(168, 271);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(428, 77);
            this.lbloutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lblsemeter);
            this.Controls.Add(this.lbldebartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.txtdebartment);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtdebartment;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldebartment;
        private System.Windows.Forms.Label lblsemeter;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbloutput;
    }
}

