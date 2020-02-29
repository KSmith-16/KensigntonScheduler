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

namespace KensigntonScheduler
{
    public partial class Form1 : Form
    {
        schedule scheduling;
        public Form1()
        {
            InitializeComponent();
            scheduling = new schedule();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//create
        {
            /*
            var reader = new StreamReader(File.OpenRead("Employees.txt"));
            while (!reader.EndOfStream)
            {
                textBox1.AppendText(reader.ReadLine() + " ");
            }
            reader.Close();
            */
            //Create.Enabled = false;
            scheduling.CreateSchedule();
            textBox1.Text = textBox1.Text+ "Created\n";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManagerButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
