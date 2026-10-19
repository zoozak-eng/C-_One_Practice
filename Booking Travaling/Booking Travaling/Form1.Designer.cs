namespace Booking_Travaling
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
            this.listoutput = new System.Windows.Forms.ListBox();
            this.groupboxinfo = new System.Windows.Forms.GroupBox();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltekate = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.groupradio = new System.Windows.Forms.GroupBox();
            this.radiobusnis = new System.Windows.Forms.RadioButton();
            this.radionormal = new System.Windows.Forms.RadioButton();
            this.radiofirst = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkadd = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupboxinfo.SuspendLayout();
            this.groupradio.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listoutput
            // 
            this.listoutput.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listoutput.FormattingEnabled = true;
            this.listoutput.ItemHeight = 38;
            this.listoutput.Location = new System.Drawing.Point(712, 48);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(404, 574);
            this.listoutput.TabIndex = 0;
            // 
            // groupboxinfo
            // 
            this.groupboxinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupboxinfo.Controls.Add(this.txtkg);
            this.groupboxinfo.Controls.Add(this.txttickets);
            this.groupboxinfo.Controls.Add(this.txtage);
            this.groupboxinfo.Controls.Add(this.txtname);
            this.groupboxinfo.Controls.Add(this.label4);
            this.groupboxinfo.Controls.Add(this.lbltekate);
            this.groupboxinfo.Controls.Add(this.lblage);
            this.groupboxinfo.Controls.Add(this.lblname);
            this.groupboxinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxinfo.Location = new System.Drawing.Point(28, 12);
            this.groupboxinfo.Name = "groupboxinfo";
            this.groupboxinfo.Size = new System.Drawing.Size(648, 280);
            this.groupboxinfo.TabIndex = 1;
            this.groupboxinfo.TabStop = false;
            this.groupboxinfo.Text = "Personal Information";
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(304, 208);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(291, 30);
            this.txtkg.TabIndex = 8;
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(304, 159);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(291, 30);
            this.txttickets.TabIndex = 7;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(304, 108);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(291, 30);
            this.txtage.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(304, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(291, 30);
            this.txtname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Baggage Weight(Kg):";
            // 
            // lbltekate
            // 
            this.lbltekate.Location = new System.Drawing.Point(6, 162);
            this.lbltekate.Name = "lbltekate";
            this.lbltekate.Size = new System.Drawing.Size(263, 27);
            this.lbltekate.TabIndex = 4;
            this.lbltekate.Text = "Number Of Tickets:";
            // 
            // lblage
            // 
            this.lblage.Location = new System.Drawing.Point(6, 111);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(246, 27);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Passenger Age:";
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(6, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(246, 27);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Passenger Name:";
            // 
            // groupradio
            // 
            this.groupradio.Controls.Add(this.radiobusnis);
            this.groupradio.Controls.Add(this.radionormal);
            this.groupradio.Controls.Add(this.radiofirst);
            this.groupradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupradio.Location = new System.Drawing.Point(28, 298);
            this.groupradio.Name = "groupradio";
            this.groupradio.Size = new System.Drawing.Size(648, 88);
            this.groupradio.TabIndex = 9;
            this.groupradio.TabStop = false;
            this.groupradio.Text = "Travel Class";
            // 
            // radiobusnis
            // 
            this.radiobusnis.AutoSize = true;
            this.radiobusnis.Location = new System.Drawing.Point(363, 36);
            this.radiobusnis.Name = "radiobusnis";
            this.radiobusnis.Size = new System.Drawing.Size(186, 29);
            this.radiobusnis.TabIndex = 2;
            this.radiobusnis.TabStop = true;
            this.radiobusnis.Text = "Business Class";
            this.radiobusnis.UseVisualStyleBackColor = true;
            // 
            // radionormal
            // 
            this.radionormal.AutoSize = true;
            this.radionormal.Location = new System.Drawing.Point(189, 36);
            this.radionormal.Name = "radionormal";
            this.radionormal.Size = new System.Drawing.Size(166, 29);
            this.radionormal.TabIndex = 1;
            this.radionormal.TabStop = true;
            this.radionormal.Text = "Normal Class";
            this.radionormal.UseVisualStyleBackColor = true;
            // 
            // radiofirst
            // 
            this.radiofirst.AutoSize = true;
            this.radiofirst.Location = new System.Drawing.Point(20, 36);
            this.radiofirst.Name = "radiofirst";
            this.radiofirst.Size = new System.Drawing.Size(140, 29);
            this.radiofirst.TabIndex = 0;
            this.radiofirst.TabStop = true;
            this.radiofirst.Text = "First Class";
            this.radiofirst.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkadd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 86);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Options";
            // 
            // checkadd
            // 
            this.checkadd.Location = new System.Drawing.Point(49, 29);
            this.checkadd.Name = "checkadd";
            this.checkadd.Size = new System.Drawing.Size(469, 43);
            this.checkadd.TabIndex = 11;
            this.checkadd.Text = "Add Travel Insures($25 Per Ticket).";
            this.checkadd.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(77, 501);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(168, 90);
            this.btncalculate.TabIndex = 11;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(276, 501);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(168, 90);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clea&r";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(455, 501);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(168, 90);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 672);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupradio);
            this.Controls.Add(this.groupboxinfo);
            this.Controls.Add(this.listoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxinfo.ResumeLayout(false);
            this.groupboxinfo.PerformLayout();
            this.groupradio.ResumeLayout(false);
            this.groupradio.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupboxinfo;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltekate;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupradio;
        private System.Windows.Forms.RadioButton radiobusnis;
        private System.Windows.Forms.RadioButton radionormal;
        private System.Windows.Forms.RadioButton radiofirst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkadd;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listoutput;
    }
}

