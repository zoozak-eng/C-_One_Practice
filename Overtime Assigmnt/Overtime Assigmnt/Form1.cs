using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overtime_Assigmnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //creating varibals
            double houres, hourly, groos, overtime,
            overtimepay;

            //Get info From The User
            houres = double.Parse(txtHoursWorked.Text);
            hourly = double.Parse(txtHourly.Text);
            //using nasted if for the Calculate 
            try
            {
                if (houres > 40)
                {


                    overtime = houres - 40;
                    overtimepay = overtime * (hourly * 1.5);

                    groos = (40 * hourly) + overtimepay;

                    if (groos > 0)
                    {
                        lblGroospay.Text = groos.ToString("C");
                    }
                }
                            
                else
                {
                    groos = houres * hourly;
                }
                lbloutput.Text = groos.ToString("c");

            
                   

            }
            catch
            {
                MessageBox.Show("Wax Saxan Soo Geli Wll");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing The Text Box
            txtHoursWorked.Text = string.Empty;
            txtHourly.Text = string.Empty;

            //claring labl
            lbloutput.Text= string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
