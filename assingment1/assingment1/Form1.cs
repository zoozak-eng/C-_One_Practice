using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment1
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

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //steep 1
            string name, id, deprt, semester,fullinfo;
            name=txtname.Text;
            id=txtstudentid.Text;
            deprt=txtdebartment.Text;
            semester=txtsemester.Text;
            

            //steep 2

            fullinfo = name + " , " + id + " , " + deprt + " , " + semester;

            //steep 3 output
            lbloutput.Text = fullinfo;

        }
        //step 4 clearing 
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdebartment.Clear();
            txtsemester.Clear();
            //step 5 clearing label
            lbloutput.Text=string.Empty;
        }
    }
}
