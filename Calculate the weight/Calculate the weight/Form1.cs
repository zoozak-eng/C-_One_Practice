using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_the_weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating varibales
            string name="";
            double weight = 0;
            double Height = 0;
            double BMI= 0;

            //VALIDATE INPUTS VARIBALES
            name=txtname.Text;
            
            if (double.TryParse(txtweight.Text, out weight))
            {

            }
            else
            {
                MessageBox.Show("Please Enter your Weight To Culculate Your BMI");
            }
            if (double.TryParse(txtheight.Text, out Height))
            {
            }
            else {
                MessageBox.Show("Please Enter your Height To Culculate Your BMI");
            }
            //Cheeking the Input For Invalid Numeric
            BMI = weight * 703 / (Height * Height);
            if (weight < 1 || Height < 1)
            {
                MessageBox.Show("Please enter valid number");

            }
            //valdtions for Bmi
            if (weight < 18.5)
            {
                listBoxDisblay.Items.Add("You Are Underweight");
         
            }
           else if (weight >= 18.5 && weight < 25)
            {
                listBoxDisblay.Items.Add("You Are Optimal Weight");

            }
           else 
            {
             listBoxDisblay.Items.Add("You are Overweight");
             }
        


            listBoxDisblay.Items.Add("Name: "+name);
            listBoxDisblay.Items.Add("Weight: "+weight+"Kg");
            listBoxDisblay.Items.Add("Height:" + Height + "M");
            listBoxDisblay.Items.Add("BMI:" + BMI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
