namespace Test_Score_Avreage
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
            this.groupboxtest = new System.Windows.Forms.GroupBox();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.lbltest1 = new System.Windows.Forms.Label();
            this.lbltest2 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblAvrage = new System.Windows.Forms.Label();
            this.Btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupboxtest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxtest
            // 
            this.groupboxtest.BackColor = System.Drawing.SystemColors.Control;
            this.groupboxtest.Controls.Add(this.lblAvrage);
            this.groupboxtest.Controls.Add(this.lbloutput);
            this.groupboxtest.Controls.Add(this.lblscore3);
            this.groupboxtest.Controls.Add(this.lbltest2);
            this.groupboxtest.Controls.Add(this.lbltest1);
            this.groupboxtest.Controls.Add(this.txtscore3);
            this.groupboxtest.Controls.Add(this.txtscore2);
            this.groupboxtest.Controls.Add(this.txtTest1);
            this.groupboxtest.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxtest.Location = new System.Drawing.Point(196, 37);
            this.groupboxtest.Name = "groupboxtest";
            this.groupboxtest.Size = new System.Drawing.Size(518, 268);
            this.groupboxtest.TabIndex = 0;
            this.groupboxtest.TabStop = false;
            this.groupboxtest.Text = "Enter Three Test Score";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(257, 47);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(232, 34);
            this.txtTest1.TabIndex = 1;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(257, 91);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(232, 34);
            this.txtscore2.TabIndex = 2;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(257, 139);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(232, 34);
            this.txtscore3.TabIndex = 3;
            // 
            // lbltest1
            // 
            this.lbltest1.Location = new System.Drawing.Point(20, 47);
            this.lbltest1.Name = "lbltest1";
            this.lbltest1.Size = new System.Drawing.Size(212, 26);
            this.lbltest1.TabIndex = 4;
            this.lbltest1.Text = "Test Score #1:";
            // 
            // lbltest2
            // 
            this.lbltest2.Location = new System.Drawing.Point(20, 91);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(212, 26);
            this.lbltest2.TabIndex = 5;
            this.lbltest2.Text = "Test Score #2:";
            // 
            // lblscore3
            // 
            this.lblscore3.Location = new System.Drawing.Point(20, 139);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(212, 26);
            this.lblscore3.TabIndex = 6;
            this.lblscore3.Text = "Test Score #3:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(257, 188);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(232, 56);
            this.lbloutput.TabIndex = 7;
            // 
            // lblAvrage
            // 
            this.lblAvrage.Location = new System.Drawing.Point(62, 189);
            this.lblAvrage.Name = "lblAvrage";
            this.lblAvrage.Size = new System.Drawing.Size(170, 48);
            this.lblAvrage.TabIndex = 1;
            this.lblAvrage.Text = "Average:";
            this.lblAvrage.Click += new System.EventHandler(this.lblAvrage_Click);
            // 
            // Btnclear
            // 
            this.Btnclear.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclear.Location = new System.Drawing.Point(508, 321);
            this.Btnclear.Name = "Btnclear";
            this.Btnclear.Size = new System.Drawing.Size(177, 65);
            this.Btnclear.TabIndex = 1;
            this.Btnclear.Text = "Clea&r";
            this.Btnclear.UseVisualStyleBackColor = true;
            this.Btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(508, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 65);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(246, 335);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(232, 122);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate\r\nAverage";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 500);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Btnclear);
            this.Controls.Add(this.groupboxtest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxtest.ResumeLayout(false);
            this.groupboxtest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxtest;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lbltest2;
        private System.Windows.Forms.Label lbltest1;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.Label lblAvrage;
        private System.Windows.Forms.Button Btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btncalculate;
    }
}

