using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_assignmentt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //creating varibals
            string dayof_week, Name_of_Month, Numaric_MONTH, year, Full_date;

            //intial values to varibal

            dayof_week = txtdayoftheweek.Text;
            Name_of_Month = txtmoth.Text;
            Numaric_MONTH=txtdayofthemonth.Text;
            year = txtyear.Text;
            int.Parse(Numaric_MONTH); 
            int.Parse(year);
            


            //stage 2 =Process-Concatination of full date

            Full_date = dayof_week + " , " + Name_of_Month 
                + " , " + Numaric_MONTH + " , " + year;

            //Stage3= display using labale
            lbloutput.Text = Full_date;
        }

        private void btncleear_Click(object sender, EventArgs e)
        {
            //clearing texbox and labale
            //clearing textbox
            txtdayoftheweek.Clear();
            txtdayofthemonth.Clear();
            txtdayofthemonth.Text = "";
            txtmoth.Text = string.Empty;
            txtyear.Clear();

            //clearing lable
            lbloutput.Text=" ";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //from Close
            this.Close();
        }
    }
}
