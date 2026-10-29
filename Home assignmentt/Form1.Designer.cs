namespace Home_assignmentt
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
            this.lbloftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblnumeric = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtmoth = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btncleear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbloftheweek
            // 
            this.lbloftheweek.AutoSize = true;
            this.lbloftheweek.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloftheweek.Location = new System.Drawing.Point(68, 81);
            this.lbloftheweek.Name = "lbloftheweek";
            this.lbloftheweek.Size = new System.Drawing.Size(253, 27);
            this.lbloftheweek.TabIndex = 0;
            this.lbloftheweek.Text = "Enter Day Of The Week:";
            this.lbloftheweek.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(36, 120);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(285, 27);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter Name Of The Month:";
            this.lblnameofthemonth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnumeric
            // 
            this.lblnumeric.AutoSize = true;
            this.lblnumeric.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeric.Location = new System.Drawing.Point(11, 159);
            this.lblnumeric.Name = "lblnumeric";
            this.lblnumeric.Size = new System.Drawing.Size(310, 27);
            this.lblnumeric.TabIndex = 2;
            this.lblnumeric.Text = "Enter Numeric Of The Month:";
            this.lblnumeric.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(156, 195);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(165, 27);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter The Year:";
            this.lblyear.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(41, 253);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(659, 103);
            this.lbloutput.TabIndex = 4;
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(357, 74);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(343, 39);
            this.txtdayoftheweek.TabIndex = 5;
            this.txtdayoftheweek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmoth
            // 
            this.txtmoth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoth.Location = new System.Drawing.Point(357, 113);
            this.txtmoth.Name = "txtmoth";
            this.txtmoth.Size = new System.Drawing.Size(343, 39);
            this.txtmoth.TabIndex = 6;
            this.txtmoth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofthemonth.Location = new System.Drawing.Point(357, 152);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(343, 39);
            this.txtdayofthemonth.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(357, 188);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(343, 39);
            this.txtyear.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(41, 368);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(190, 48);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "Shwo Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btncleear
            // 
            this.btncleear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncleear.Location = new System.Drawing.Point(261, 368);
            this.btncleear.Name = "btncleear";
            this.btncleear.Size = new System.Drawing.Size(197, 48);
            this.btncleear.TabIndex = 10;
            this.btncleear.Text = "Clear";
            this.btncleear.UseVisualStyleBackColor = true;
            this.btncleear.Click += new System.EventHandler(this.btncleear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(488, 368);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(212, 48);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(999, 538);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btncleear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtmoth);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumeric);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbloftheweek);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblnumeric;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtmoth;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btncleear;
        private System.Windows.Forms.Button btnclose;
    }
}

