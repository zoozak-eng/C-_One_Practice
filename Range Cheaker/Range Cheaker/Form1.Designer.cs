namespace Range_Cheaker
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
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnexet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.lblEntering = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbloutput);
            this.groupBox1.Controls.Add(this.btnexet);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtRange);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.lblEntering);
            this.groupBox1.Controls.Add(this.lblDecision);
            this.groupBox1.Location = new System.Drawing.Point(72, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range Checker Application:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(108, 191);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(422, 71);
            this.lbloutput.TabIndex = 14;
            // 
            // btnexet
            // 
            this.btnexet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexet.Location = new System.Drawing.Point(299, 339);
            this.btnexet.Name = "btnexet";
            this.btnexet.Size = new System.Drawing.Size(166, 54);
            this.btnexet.TabIndex = 13;
            this.btnexet.Text = "Exet";
            this.btnexet.UseVisualStyleBackColor = true;
            this.btnexet.Click += new System.EventHandler(this.btnexet_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(299, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 52);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(144, 87);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(321, 26);
            this.txtRange.TabIndex = 7;
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(108, 285);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(166, 108);
            this.btncheck.TabIndex = 11;
            this.btncheck.Text = "Check Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEntering
            // 
            this.lblEntering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntering.Location = new System.Drawing.Point(15, 32);
            this.lblEntering.Name = "lblEntering";
            this.lblEntering.Size = new System.Drawing.Size(565, 39);
            this.lblEntering.TabIndex = 8;
            this.lblEntering.Text = "Enter an integer in the range of 1 throught 10:";
            // 
            // lblDecision
            // 
            this.lblDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(191, 152);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(209, 39);
            this.lblDecision.TabIndex = 10;
            this.lblDecision.Text = "Range Decision:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblEntering;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lbloutput;
    }
}

