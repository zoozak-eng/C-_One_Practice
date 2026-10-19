using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regitration_Fee_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
        
         
            //creating varibales
            string name;
            int id, courses, levelyear,TRANSPORTFEE;
            decimal tranfee = 0;
            decimal tution = 0;
            decimal descunt = 0;
            decimal finalfee = 0;

            try
            {
                //inizlaztion
                name = txtname.Text;
                id = int.Parse(txtid.Text);
                courses = int.Parse(txtcourse.Text);
                levelyear = int.Parse(txtlevelyear.Text);
                TRANSPORTFEE = int.Parse(txtfee.Text);
                //validation name
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please Enter Your name");
                }
                else
                {

                }
                if(int.TryParse(txtfee.Text,out TRANSPORTFEE))
                {
                   
                }
                else
                {
                    MessageBox.Show("Please enter int Number");
                }

                //validate the number of courses

                if (int.TryParse(txtcourse.Text, out courses))
                {

                    if (courses < 1 || courses > 8)
                    {
                        MessageBox.Show("Number Of Courses Must Be 1-8");
                    }
                    else
                    {

                    }
                }

                //Validate Yars Levels
                if (int.TryParse(txtlevelyear.Text, out levelyear))
                {
                    if (levelyear < 1 || levelyear > 4)
                    {
                        MessageBox.Show("Please select The Level Years 1-4");
                    }
                    else
                    {

                    }




                    if (decimal.TryParse(txtfee.Text, out tranfee))
                    {


                    }
                    else if (tranfee != 40 && tranfee != 45 && tranfee != 50 && tranfee != 55)
                    {
                        MessageBox.Show("Fee Must Be A Number (40,45,50,55)");
                    }
                    switch (levelyear)
                    {
                        case 1:
                            tranfee = 40;
                            break;

                        case 2:
                            tranfee = 45;
                            break;

                        case 3:
                            tranfee = 50;
                            break;
                        case 4:
                            tranfee = 55;
                            break;


                        
                    }
                }
                else
                {

                }

                //calculate tution blance of fee
                tution = courses * tranfee;
                //validate if the student take descount
                if (courses >= 6)
                {
                    descunt = tution * 0.10m;
                }
                //Total amount
                finalfee = tution + TRANSPORTFEE - descunt;

                //disblay information
                lbldisblayname.Text = "Student Name:" + name;
                lblid2.Text = "Student Id:" + id;
                lbltransport1 .Text = "Transport Fee: $" + TRANSPORTFEE;
                lbldicount.Text = "Discount: $" + descunt;
                lbldisblayyears.Text = "Years:" + levelyear;
                lblfee.Text = "Tution Fee: $" + tution;
                lblnumbercourses.Text = "Courses:" + courses;
                lblfinalamount.Text = "Final Amount: $" + finalfee;



            }
            catch
            {
                MessageBox.Show("Please Enter Coreect Info");

            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clearing Text Box and lables
            txtname.Clear();
            txtid.Clear();
            txtcourse.Clear();
            txtfee.Clear();
            txtlevelyear.Clear();

            lbldisblayname.Text = " ";
            lblid2.Text = "";

            lbldicount.Text = " ";
            lblnumbercourses.Text = " ";
            lblfinalamount.Text = " ";
            lblfee.Text = " ";
            lbldisblayyears.Text = " ";
            lbltransport1.Text = " ";


        } 
        

    

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
