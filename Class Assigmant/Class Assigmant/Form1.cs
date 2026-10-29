using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assigmant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating varibale
            string food1, food2;
            double price1, price2;
            double total,tax;
            try {
            //Assign varibale
            food1=txtfood1.Text;
            food2=txtfood2.Text;
            price1 = double.Parse(txtprice1.Text);
            price2 = double.Parse(txtpric2.Text);
            

            total = price1 + price2;
            tax = total*0.07;


            lblcalculate.Text = "Total" + total + "  " + "tax: "+tax;

            }
            catch {
                MessageBox.Show("Enter Rihgt info.");
            }

           
        }

        private void txtfood1_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void txtfood2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtprice1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtpric2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblcalculate_Click(object sender, EventArgs e)
        {
            

        }
    }
}
