using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Cheaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating Varibale
            int range;

            try
            {
                //inistlaztion the varibale
                range = int.Parse(txtRange.Text);


                //Using If And Else Fro Cheaking The Range
                if (range < 10)
                {
                    lbloutput.Text = range + ":Is In The Range";
                }

                else
                {
                    lbloutput.Text = range + ":Is Out Of The Range We Want";
                }
            }
            catch
            {
                MessageBox.Show("Please Enter The Rhigt Info");


            }
        }

        private void btnexet_Click_1(object sender, EventArgs e)
        {
            //Cloosing The Program
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Clearing The Text Box And Lable
            txtRange.Clear();
            lbloutput.Text = string.Empty;
        }
    }
}
