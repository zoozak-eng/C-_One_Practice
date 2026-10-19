namespace Hoteel_Room_Booking
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblnightss = new System.Windows.Forms.Label();
            this.lblgustes = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtgusts = new System.Windows.Forms.TextBox();
            this.grouptype = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radibtnstandred = new System.Windows.Forms.RadioButton();
            this.radiobtnnormal = new System.Windows.Forms.RadioButton();
            this.radiobtnhight = new System.Windows.Forms.RadioButton();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listboxdisblay = new System.Windows.Forms.ListBox();
            this.chbreakfast = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grouptype.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbltitle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(336, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(383, 48);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "Hoteel Room Booking System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgusts);
            this.groupBox1.Controls.Add(this.txtnights);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblgustes);
            this.groupBox1.Controls.Add(this.lblnightss);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 276);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(28, 53);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(218, 35);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Guest Name:";
            // 
            // lblage
            // 
            this.lblage.Location = new System.Drawing.Point(28, 111);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(218, 35);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Guest Age:";
            // 
            // lblnightss
            // 
            this.lblnightss.Location = new System.Drawing.Point(28, 165);
            this.lblnightss.Name = "lblnightss";
            this.lblnightss.Size = new System.Drawing.Size(294, 43);
            this.lblnightss.TabIndex = 3;
            this.lblnightss.Text = "Number Of Nights:";
            // 
            // lblgustes
            // 
            this.lblgustes.Location = new System.Drawing.Point(28, 214);
            this.lblgustes.Name = "lblgustes";
            this.lblgustes.Size = new System.Drawing.Size(283, 43);
            this.lblgustes.TabIndex = 4;
            this.lblgustes.Text = "Number Of Guests:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(317, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(247, 35);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(317, 111);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(247, 35);
            this.txtage.TabIndex = 6;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(317, 162);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(247, 35);
            this.txtnights.TabIndex = 7;
            // 
            // txtgusts
            // 
            this.txtgusts.Location = new System.Drawing.Point(317, 211);
            this.txtgusts.Name = "txtgusts";
            this.txtgusts.Size = new System.Drawing.Size(247, 35);
            this.txtgusts.TabIndex = 8;
            // 
            // grouptype
            // 
            this.grouptype.Controls.Add(this.radiobtnhight);
            this.grouptype.Controls.Add(this.radiobtnnormal);
            this.grouptype.Controls.Add(this.radibtnstandred);
            this.grouptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouptype.Location = new System.Drawing.Point(38, 368);
            this.grouptype.Name = "grouptype";
            this.grouptype.Size = new System.Drawing.Size(660, 89);
            this.grouptype.TabIndex = 9;
            this.grouptype.TabStop = false;
            this.grouptype.Text = "Room Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbreakfast);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 89);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Option";
            // 
            // radibtnstandred
            // 
            this.radibtnstandred.Location = new System.Drawing.Point(49, 29);
            this.radibtnstandred.Name = "radibtnstandred";
            this.radibtnstandred.Size = new System.Drawing.Size(161, 31);
            this.radibtnstandred.TabIndex = 11;
            this.radibtnstandred.TabStop = true;
            this.radibtnstandred.Text = "Standred";
            this.radibtnstandred.UseVisualStyleBackColor = true;
            // 
            // radiobtnnormal
            // 
            this.radiobtnnormal.Location = new System.Drawing.Point(244, 29);
            this.radiobtnnormal.Name = "radiobtnnormal";
            this.radiobtnnormal.Size = new System.Drawing.Size(161, 31);
            this.radiobtnnormal.TabIndex = 12;
            this.radiobtnnormal.TabStop = true;
            this.radiobtnnormal.Text = "Normal";
            this.radiobtnnormal.UseVisualStyleBackColor = true;
            // 
            // radiobtnhight
            // 
            this.radiobtnhight.Location = new System.Drawing.Point(450, 29);
            this.radiobtnhight.Name = "radiobtnhight";
            this.radiobtnhight.Size = new System.Drawing.Size(161, 31);
            this.radiobtnhight.TabIndex = 13;
            this.radiobtnhight.TabStop = true;
            this.radiobtnhight.Text = "Hight";
            this.radiobtnhight.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(109, 593);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(149, 81);
            this.btncalculate.TabIndex = 11;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(282, 593);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(149, 81);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Cl&ear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(454, 593);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(149, 81);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listboxdisblay
            // 
            this.listboxdisblay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxdisblay.FormattingEnabled = true;
            this.listboxdisblay.ItemHeight = 26;
            this.listboxdisblay.Location = new System.Drawing.Point(726, 70);
            this.listboxdisblay.Name = "listboxdisblay";
            this.listboxdisblay.Size = new System.Drawing.Size(377, 576);
            this.listboxdisblay.TabIndex = 14;
            // 
            // chbreakfast
            // 
            this.chbreakfast.Location = new System.Drawing.Point(33, 30);
            this.chbreakfast.Name = "chbreakfast";
            this.chbreakfast.Size = new System.Drawing.Size(562, 53);
            this.chbreakfast.TabIndex = 0;
            this.chbreakfast.Text = "BreakFast (10 Per Guest per Nigthts).";
            this.chbreakfast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 700);
            this.Controls.Add(this.listboxdisblay);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grouptype);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grouptype.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgusts;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblgustes;
        private System.Windows.Forms.Label lblnightss;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox grouptype;
        private System.Windows.Forms.RadioButton radiobtnhight;
        private System.Windows.Forms.RadioButton radiobtnnormal;
        private System.Windows.Forms.RadioButton radibtnstandred;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listboxdisblay;
        private System.Windows.Forms.CheckBox chbreakfast;
    }
}

