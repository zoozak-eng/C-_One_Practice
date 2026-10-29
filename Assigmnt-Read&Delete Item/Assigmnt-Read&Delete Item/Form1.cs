using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigmnt_Read_Delete_Item
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCraetFile_Click(object sender, EventArgs e)
        {
            //Create File To Use It To Read
            //Import Class
            StreamWriter NFeli;

            //Craeting The File
            NFeli = File.CreateText("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Assigmnt.txt");

            //Process To Writing In The File 
            NFeli.WriteLine("My Name Is Zamzam Abdulaziz Sheekh Jumac");
            NFeli.WriteLine("Iam Universty Student Year3 And My Fucalty Is IT Bachular Computer Appliction ");
            NFeli.WriteLine("Age: 20");

            //Closing the File
            NFeli.Close();

            //Mesage to know The File Is Creating
            MessageBox.Show("Succcsful");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            //Creating Peek()Read-Function to Read All Text From The File 
            //Import The Class With Object
            StreamReader SR = new StreamReader("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Assigmnt.txt");
            //The Process Whith While Loop
            while(SR.Peek() != -1)
            {
                listBoxDisblay.Items.Add(SR.ReadLine());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Another Way To Use Peek() 
            //Import The Class With Object
            StreamReader sr = new StreamReader("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Assigmnt.txt");
            //The Process With Out loop To Read First Charcter Using Peek()
            int Ch=sr.Peek();
            listBoxDisblay.Items.Add((char)Ch);
        }

        private void btnLeanth_Click(object sender, EventArgs e)
        {
            //Creating Object To Hold The File 
           FileInfo Read =new FileInfo("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Assigmnt.txt");
            //The Process To Disblay The Leanth
            listBoxDisblay.Items.Add("File Size:" +Read.Length +"Bytes");
        }

        private async void btnEndAsync_Click(object sender, EventArgs e)
        {
            //Craeting ReadToEndAsync() Function
            StreamReader rread = File.OpenText("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Assigmnt.txt");
            //process To Read To End In One Line
            string textt=await rread.ReadToEndAsync();

            //Disblay On The ListBox
            listBoxDisblay.Items.Add(textt);

            MessageBox.Show("Succesful");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Validate That Cheekid If The File Is Cratid To Dalete
            if (File.Exists("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Index.txt"))
            {
                File.Delete("C:\\Users\\pc\\OneDrive\\Desktop\\C# Assigmnt\\Index.txt");

                MessageBox.Show("File is deleting Succesful");
            }
            else
            {
                MessageBox.Show("File is Not Exist");
            }

        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            //Deleting Folder 
            Directory.Delete("C:\\Users\\pc\\OneDrive\\Documents\\Example",true);//True=And Deleting Every Thing In Tha Folder

            MessageBox.Show("Yor Folder Is Deleting Succeful");
        }
    }
}
