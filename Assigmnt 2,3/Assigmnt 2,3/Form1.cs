using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Assigmnt_2_3
{
    public partial class Form1 : Form
    {
        //Global Varibale Used For All Parts Of The Metods
        decimal totalfee = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //btn Clossing The Program
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Varibalis
                string sname = " ";
                int Sage;
                int Sid = 0;
                int Coursenum;
                double total = 0;
                double coursepric = 0;
                double discount = 0;
                double BeforeDiscont = 0;
                
                //input validations
                coursepric = int.Parse(txtprice.Text);
                Sid = int.Parse(txtid.Text);
                sname = txtname.Text;

                //validation For Number OF Courses
                if (int.TryParse(txtnumofcourse.Text, out Coursenum))
                {

                }
                else
                {
                    MessageBox.Show("Please enter at list one course");

                }
                //validate for Id is not empty


                if (txtid.Text.Length==0)
                {
                    MessageBox.Show("Please Enter Your Id");
                }
                else
                {

                }
                //Validate For Age 
                if (int.TryParse(txtage.Text, out Sage))
                {

                }
                else
                {
                    MessageBox.Show("Please Enter Corect Age");
                }
                if (Sage < 16 || Sage > 60)
                {
                    MessageBox.Show("You Can Not Enter To Universty Because Your Age Is Must Be Between 16-60");
                }

                //Validate For Course Number to Cheeking

                if (Coursenum < 0 && Coursenum > 5)
                {
                    MessageBox.Show("Course Number Must Be 1-5 ");
                }

                //Additon Before Descount 
                coursepric =(double) totalfee;
                //Validationn For Discount
                if (Coursenum == 2)
                {
                    discount = (int)coursepric * 0.05;
                    BeforeDiscont = (double)totalfee;
                    total = BeforeDiscont - discount;
                }
                else if (Coursenum == 3 || Coursenum == 4)
                {
                    discount = (int)coursepric * 0.10;
                    BeforeDiscont = (double)totalfee;
                    total = BeforeDiscont - discount;
                }
                else if (Coursenum == 5)
                {
                    discount = (int)coursepric * 0.15;
                    BeforeDiscont =(double) totalfee;
                    total = BeforeDiscont - discount;
                }

               //Disblay Output In the ListBox Disblay

                listboxdisblay.Items.Add("=====Student Registrtion=====");
                listboxdisblay.Items.Add("Name:" + sname);
                listboxdisblay.Items.Add("ID :" + Sid);
                listboxdisblay.Items.Add("Number Of Course:" + Coursenum);
                listboxdisblay.Items.Add("Registion Fee: $" + coursepric);
                listboxdisblay.Items.Add("Before Discount:"+BeforeDiscont);
                listboxdisblay.Items.Add("-----------------------------------");
                listboxdisblay.Items.Add("Discount: -" + discount);
                listboxdisblay.Items.Add("RegistionFee After Discount : $" + total);

               
            }

            //Expiton Handaling
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Varibalis
                string courseName;
                decimal coursePrice = 0;
                int coursenum = 0;
                double registrionfee = 0;
                double discont, total;

                //Validtion For Course
                courseName = txtcourse.Text;

                if (txtcourse.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter a Course");
                }
                //Validate For Course Price
                if (decimal.TryParse(txtprice.Text, out coursePrice))
                {

                }
                else
                {
                    MessageBox.Show("Please Enter Course Price");
                }
                if (coursePrice <= 0)
                {
                    MessageBox.Show("Price Can Not Be Negative");
                }
                //Validate Number Of Course
                if (coursenum < 0 && coursenum > 5)
                {
                    MessageBox.Show("Course Number Must Be 1-5 ");
                }

               //Disblay In ListBox Course And Ther Price
                listboxcourse.Items.Add(txtcourse.Text+" "+"$"+coursePrice);
                //Add Every Course Price In The Global Varibale TotalFee
                totalfee = totalfee + coursePrice;
                
                

            }
            //Exaption Handaling
            catch (Exception ex) {
                MessageBox.Show("Unexpected Error:"+ex.Message);
            }

         
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            //Validate Remove Btn If Is empty
            if (txtcourse.Text.Length == 0)
            {
                MessageBox.Show("Please Select course to remove");
            }
            else if(txtprice.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Priace to remove");
            }
            //Removeing Course Name And Cource Price
            txtcourse.Clear();
            txtprice.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clearing All Parts
            listboxcourse.Items.Clear();
            txtname.Clear();
            txtage.Clear();
            txtid.Clear();
            listboxdisblay.Items.Clear();
            txtcourse.Clear();
            txtprice.Clear();
            txtnumofcourse.Clear();
        }
    }
}
