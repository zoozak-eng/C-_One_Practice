using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteel_Room_Booking
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

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Creating Vriblae
            string name;
            string roomtype = " ";
            int age, nights, gusts;
            decimal breakfast = 0;
            int rate = 0;
            int maxgust = 0;
            decimal discont = 0;
            bool BookingApprovid = true;
            int cost = 0;
            decimal surcharge = 0;
            decimal Seniordescont = 0;

            decimal total;
           
            //Inizallion varbles
            name = txtname.Text;
            age=int.Parse(txtage.Text);
            nights=int.Parse(txtnights.Text);
            gusts=int.Parse(txtgusts.Text);

            //Validate The Guste Name
            if(string.IsNullOrEmpty(name))
            {
               MessageBox.Show("Name Can Not Be Empty.");
                
            }
            else
            {

            }
            //Validate The Guste Age Using Try Parse
            if (int.TryParse(txtage.Text, out age))
            {
                if (age < 18 || age > 90)
                {
                    MessageBox.Show("The Age Must Be Between 18-90.");
                }

                else
                {


                }
            }

            //Validate The Number Of  Guste  Using Try Parse
            if (int.TryParse(txtgusts.Text, out gusts))
            {
                if (gusts < 1 || gusts > 6)
                {
                    MessageBox.Show("The Number Og Guesst Must Be Between 1-6");
                }
                else
                {
                       
                }
            }
            //Validate The Guste nights Using Try Parse
            if (int.TryParse(txtnights.Text, out nights))
            {
                if(nights < 1 || nights > 30)
                {
                    MessageBox.Show("Sorry The Nights Can Not More Than 30 Days. ");
                }
                else
                {
                        
                }
            }
            //Check Which Room type The Guest 
            if (radibtnstandred.Checked) roomtype = "Standred";
            else if (radiobtnnormal.Checked) roomtype = "Normal";
            else if (radiobtnhight.Checked) roomtype = "Hight";
            //Use Switch To detrmaine The Room Rate And Miximum Guests
            switch (roomtype) {
                case "Standred":
                    rate = 50;
                    maxgust = 2;
                    break;
                case "Normal":
                    rate = 80;
                    maxgust = 4;
                    break;
                case "Hight":
                    rate = 160;
                    maxgust = 6;
                    break;

                default:
                    {
                        MessageBox.Show("Please Select Room Type You Want");
                    }
                    break;
            }
            //Check Whether the selected room allwos the number of guests

            if(roomtype!=" "&& gusts > maxgust)
            {
                MessageBox.Show(roomtype+"Room Allows A Maximum Of "+maxgust+" Gustes Sorry.");

            }
          //Cheeking whether Booking Is Approvid
            if(BookingApprovid == true)
            {
               

            }
            else
            {
                MessageBox.Show("Sorry Your Booking Is Rajactid");
            }
            //Calculate room cost

            cost = rate * nights;
            //Calculate Discont Of Nhites
            if (nights >= 10)
            {
                discont = 0.12m;
            }
            else if(nights>=5)
            {
                discont = 0.05m;
            }

         decimal nightdescont = cost * discont;
         decimal afterdiscont = cost - nightdescont;
            //Cheecked When The Costumer Select Breakfast
            if (chbreakfast.Checked)
            {
                breakfast = 10 * nights;
                 
            }
            //Discont For aged More Then 60
            if (age >= 60)
            {
                Seniordescont = afterdiscont * 0.05m;
            }
            //Discount For Pepole More Then 4
            if (gusts >= 4)
            {
                surcharge = afterdiscont * 0.05m;
            }
            //Calculate total Amount
            total = afterdiscont - Seniordescont - surcharge + breakfast;

            // Display Information in List Box
            listboxdisblay.Items.Add("Booking Approvid:"+ BookingApprovid);
            listboxdisblay.Items.Add(" ");
            listboxdisblay.Items.Add("Gustes Name:"+name);
            listboxdisblay.Items.Add("Age:" + age);
            listboxdisblay.Items.Add("Room Type:" + roomtype);
            listboxdisblay.Items.Add("Rate of The Type Room: $" + rate);
            listboxdisblay.Items.Add("Gusts:" + gusts);
            listboxdisblay.Items.Add("Nights:" + nights);
            listboxdisblay.Items.Add("Room Cost: $" + cost);
            listboxdisblay.Items.Add("Night Desconts: $" + nightdescont);
            listboxdisblay.Items.Add("Senior Descount: $" + Seniordescont);
            listboxdisblay.Items.Add("Service Surcharge: $" + surcharge);
            listboxdisblay.Items.Add("Brekfast Cost: $" + breakfast);
            listboxdisblay.Items.Add("------------------------------");
            listboxdisblay.Items.Add("Total Cost: $" + total);
                 


            }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear Text boxes,listbox and Boutnes
            listboxdisblay.Items.Clear();
            txtage.Clear();
            txtgusts.Clear();
            txtnights.Clear();
            txtname.Clear();
            radibtnstandred.Checked = false;
            radiobtnnormal.Checked = false;
            radiobtnhight.Checked = false;
            chbreakfast.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //close The Program
            this.Close();
        }
    }
    }

