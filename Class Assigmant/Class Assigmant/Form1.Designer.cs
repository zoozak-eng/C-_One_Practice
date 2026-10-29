namespace Class_Assigmant
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtpric2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblprice1 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.lblcalculate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(354, 107);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(250, 26);
            this.txtfood1.TabIndex = 0;
            this.txtfood1.TextChanged += new System.EventHandler(this.txtfood1_TextChanged);
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(354, 151);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(250, 26);
            this.txtprice1.TabIndex = 1;
            this.txtprice1.TextChanged += new System.EventHandler(this.txtprice1_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(354, 196);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(250, 26);
            this.txtfood2.TabIndex = 2;
            this.txtfood2.TextChanged += new System.EventHandler(this.txtfood2_TextChanged);
            // 
            // txtpric2
            // 
            this.txtpric2.Location = new System.Drawing.Point(354, 240);
            this.txtpric2.Name = "txtpric2";
            this.txtpric2.Size = new System.Drawing.Size(250, 26);
            this.txtpric2.TabIndex = 3;
            this.txtpric2.TextChanged += new System.EventHandler(this.txtpric2_TextChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(218, 272);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(182, 75);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculute";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblfood1
            // 
            this.lblfood1.Location = new System.Drawing.Point(214, 107);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(118, 23);
            this.lblfood1.TabIndex = 5;
            this.lblfood1.Text = "Enter Food 1:";
            // 
            // lblprice1
            // 
            this.lblprice1.Location = new System.Drawing.Point(214, 151);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(134, 26);
            this.lblprice1.TabIndex = 6;
            this.lblprice1.Text = "Enter Price 1:";
            // 
            // lblfood2
            // 
            this.lblfood2.Location = new System.Drawing.Point(214, 196);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(134, 26);
            this.lblfood2.TabIndex = 7;
            this.lblfood2.Text = "Enter Food2:";
            // 
            // lblprice2
            // 
            this.lblprice2.Location = new System.Drawing.Point(214, 243);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(134, 23);
            this.lblprice2.TabIndex = 8;
            this.lblprice2.Text = "Enter Price2:";
            // 
            // lblcalculate
            // 
            this.lblcalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcalculate.Location = new System.Drawing.Point(406, 272);
            this.lblcalculate.Name = "lblcalculate";
            this.lblcalculate.Size = new System.Drawing.Size(311, 93);
            this.lblcalculate.TabIndex = 9;
            this.lblcalculate.Click += new System.EventHandler(this.lblcalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(this.lblcalculate);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblprice1);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpric2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtpric2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblprice1;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.Label lblcalculate;
    }
}

