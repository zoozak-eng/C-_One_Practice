using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Avreage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAvrage_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Creating Varibals
            double test1, test2, test3, avreage;
            string grade = " ";

            try
            {
                //Get Score From The User
            test1 = double.Parse(txtTest1.Text);
            test2 = double.Parse(txtscore2.Text);
            test3 = double.Parse(txtscore3.Text);


            //Calculate The Avrage
            avreage = (test1 + test2 + test3) / 3;



            //using if and ifelse for combaris

            
                if (avreage >= 90)
                {
                    grade = "A+";
                }
                else if (avreage >= 80)
                {
                    grade = "A";
                }

                else if (avreage >= 70)
                {

                    grade = "B+";

                }
                else if (avreage >= 60)
                {
                    grade = "B";
                }

                else
                {
                    MessageBox.Show("You Fill Sorry");
                }
                //displaying Output On The Label
                lbloutput.Text = "Avrage:" + avreage.ToString("f1") + " Grade:" + grade;


            }
            catch
            {
                MessageBox.Show("Enter Right information pleas.");
            }
        }

            

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //Cleearing Text box
            txtTest1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();

            //clearing the lebale

            lbloutput.Text= " ";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cloos the program

            this.Close();
        }
    }
}
