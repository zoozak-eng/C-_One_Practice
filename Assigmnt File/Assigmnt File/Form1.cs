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

namespace Assigmnt_File
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

        private void btnAssigmnt_Click(object sender, EventArgs e)
        {
            //import class
            StreamWriter Write;

            //open the file
            Write = File.CreateText("C:\\Users\\pc\\OneDrive\\Documents\\Zaam.txt");

            //Process file
            Write.WriteLine("Asc Asxabee waa idin salamay");
            Write.WriteLine("Ina Ficantihin Idin Rajeena");

            //close the file
            Write.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter write;

            DialogResult result;
            result=saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                write = new StreamWriter(saveFileDialog1.FileName);
                write.WriteLine(textBox1.Text);
                write.Close();

                MessageBox.Show("Saved Your File");

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) { 
            reader=new StreamReader(openFileDialog1.FileName);
                string line;

                while (reader.EndOfStream == false)
                {
                    line= reader.ReadLine();
                    listBox1.Items.Add(line);
                }

            }
        }
    }
}
