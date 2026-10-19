using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_Travaling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating Variblis
            string name="";
            double weight,total,descont;
            int age, tickit;
            int classnumber = 0;
            double descountiga = 0;
            double price = 0;
            double cost;
            double agedes = 0;
            double insures = 0;
            double bagfee = 0;
            bool BookingApproverd = true;
           


            //Validtions for cheking to input correct info
           
            if (string.IsNullOrEmpty(name)) {

               
            }
            else
            {
                MessageBox.Show("Please Name Can Not Be Empty");
                return;

            }
           
            if (int.TryParse(txtage.Text, out age))
            {
                
            }
            else
            {
                MessageBox.Show("Please Enter Age");
                return;
            }

            if (int.TryParse(txttickets.Text, out tickit))
            {
               
            }
            else
            {
                MessageBox.Show("Enter Tikcet Number");
                return;

            }

            if (double.TryParse(txtkg.Text,out weight))
            {
                
            }
            else
            {
                MessageBox.Show("Enter Weight");
                return;
            }

                //VALDITIONKA XISABINTA
                if (age < 1 || age > 100)
                {
                MessageBox.Show("Da Saxan Soo Gili");
                BookingApproverd=false;
                }
             if(tickit<1||tickit>5) {
                MessageBox.Show("Tickitka loo ma ogolo tirada aa soo gilisay only 1-5");
                BookingApproverd = false;
            }
            if (age < 12 && radiofirst.Checked)
            {
                MessageBox.Show("In Firsclass must you age is abouve 12");
                BookingApproverd = false;
            }
            if (weight<0 || weight > 50)
            {
                MessageBox.Show("Wightkan Lama Ogalo Wax Ka Bdn 50Kg");
                BookingApproverd = false;
            } 
             if(!radiofirst.Checked && !radionormal.Checked && !radiobusnis.Checked)
            {
                MessageBox.Show("Pleas Select Travle Level");
                BookingApproverd= false;
            }

            //tikitka qimahisa


            if (radiofirst.Checked)
            {
                classnumber = 1;
            }
            else if (radionormal.Checked)
            {
                classnumber = 2;
            }
            else if (radiobusnis.Checked)
            {
                classnumber=3;
            }
            switch (classnumber)
            {
                case 1://first
                    price = 130;
                    break;
                case 2: //normal
                    price = 170;
                    break;
                case 3: //busniss
                    price = 300;
                    break;

            }
            //Basic cost
            cost = price * tickit;

            //discount valdtion
            if (tickit>=5)
            {
                descont = 0.10;
            }
            else if (tickit >= 3)
            {
                descont = 0.05;
            }
            else
            {
                descont = 0;
            }
            //Years Discount Valdtion

            if (age < 12)
            {
                agedes = 0.20;
            }
            else if (age >= 60)
            {
                agedes = 0.10;
            }
            else
            {  agedes = 0; }

            //Additon for descount
            descountiga = cost * descont + cost * agedes;

            //insurance ($25 )
            if (checkadd.Checked)
            {
                insures = 25 * tickit;
            }

            //bag Vlidation to cheeked more 20kg
            if (weight > 20)
            {
                bagfee = (weight - 20) * 12;
            }
            //The total after calculate
            total = cost - descont + insures + bagfee;

            //disblay Info in the list box
            listoutput.Items.Add("Booking Approvid");
            listoutput.Items.Add("Name:" + name);
            listoutput.Items.Add("Age :" + age);
            listoutput.Items.Add("Number Of Tickets:" + tickit);
            listoutput.Items.Add("Basic Cost: $"+cost);
            listoutput.Items.Add("Discount: $"+descont);
            listoutput.Items.Add("Insurance: $"+insures);
            listoutput.Items.Add("Bag's fee: $"+bagfee);
            listoutput.Items.Add("----------------------------------------");
            listoutput.Items.Add("Total: $" + total);


            }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listoutput.Items.Clear();
            txtname.Clear();
            txtage.Clear();
            txttickets.Clear();
            txtkg.Clear();
            radiofirst.Checked = false;
            radionormal.Checked = false;
            radiobusnis.Checked = false;
            checkadd.Checked = false;
        }
    }
    }

