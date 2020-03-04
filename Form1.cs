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
            populateEmployeeBox();
            populateComboBow();
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
            textBox1.Text = "";
            showSchedule(scheduling.getEmployees(), scheduling.getDays());
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
             * add in input checker to be sure ther is an input
             * */
            
            string firstNameText = FirstName.Text;
            string lastNameText = LastName.Text;

            int pos = 0;
            if (neitherRadioButton.Checked)
            {
                pos = 1;
            }
            else if (supervisorButton.Checked)
            {
                pos = 2;
            }
            else if (ManagerButton.Checked)
            {
                pos = 3;
            }

            FirstName.Text = "";
            LastName.Text = "";
            scheduling.addEmployee(firstNameText, lastNameText, pos);
            populateEmployeeBox();
            populateComboBow();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManagerButton_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void showSchedule(List<Employee> employees, List<day> days)
        {
            string tect = Environment.NewLine;
            for (int i = 0; i < 7; i++)
            {
                textBox1.AppendText(days[i].name + tect);
                textBox1.AppendText("    Splash Shifts:" + tect);
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 1)
                    {
                        textBox1.AppendText("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName+tect);
                    }
                }
                textBox1.AppendText("    Maintence Shifts(6am): "+tect);
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 2)
                    {
                        textBox1.AppendText("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName+tect);
                    }
                }

                textBox1.AppendText("    Maintence Shifts(2pm): "+tect);
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 3)
                    {
                        textBox1.AppendText("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName+tect);
                    }
                }
                textBox1.AppendText("    Managers: "+tect);
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 4)
                    {
                        textBox1.AppendText("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName+tect);
                    }
                }

            }

            for (int i = 0; i < employees.Count; i++)
            {
                textBox1.AppendText($"{employees[i].firstName}: {employees[i].hours}"+tect);
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void populateEmployeeBox()
        {
            List<Employee> employees = scheduling.getEmployees();

            textBox2.Text = "";

            for (int i = 0; i < employees.Count; i++)
            {
                textBox2.AppendText($"{employees[i].firstName} {employees[i].lastName}");
                if (employees[i].manager)
                {
                    textBox2.AppendText("  M" + Environment.NewLine);
                }
                else if (employees[i].superviser)
                {
                    textBox2.AppendText("  S" + Environment.NewLine);
                }
                else 
                {
                    textBox2.AppendText(Environment.NewLine);
                }
            }
        }

        private void populateComboBow()
        {
            List<Employee> employees = scheduling.getEmployees();
            workerComboBox_Edit.Items.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                workerComboBox_Edit.Items.Add($"{employees[i].firstName} {employees[i].lastName}");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int empIndex = getEmployeeIndex();

            scheduling.updateEmployee(empIndex, 3);

            populateEmployeeBox();
        }

        private void workerComboBox_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            neitherButton_Edit.Visible = false;
            superviserButton_Edit.Visible = false;
            managerButton_Edit.Visible = false;

            deleteButton_Edit.Enabled = true;
            tierButton_Edit.Enabled = true;
        }

        private void firstButton_Edit_Click(object sender, EventArgs e)
        {
            
            if (deleteButton_Edit.Checked)
            {
                int employeeIndex = getEmployeeIndex();
                scheduling.deleteEmployee(employeeIndex);
                populateComboBow();
                populateEmployeeBox();
            }
            else 
            {
                managerButton_Edit.Visible = true;
                superviserButton_Edit.Visible = true;
                neitherButton_Edit.Visible = true;
            }
        }

        private int getEmployeeIndex()
        {
            int answer = 0;
            List<Employee> employees = scheduling.getEmployees();
            for (int i = 0; i < employees.Count; i++)
            {
                if ($"{employees[i].firstName} {employees[i].lastName}".Equals(workerComboBox_Edit.SelectedItem))
                {
                    answer = employees[i].index;
                }
            }
            return answer;
        }

        private void neitherButton_Edit_CheckedChanged(object sender, EventArgs e)
        {
            int empIndex = getEmployeeIndex();

            scheduling.updateEmployee(empIndex, 1);

            populateEmployeeBox();
        }

        private void superviserButton_Edit_CheckedChanged(object sender, EventArgs e)
        {
            int empIndex = getEmployeeIndex();

            scheduling.updateEmployee(empIndex, 2);

            populateEmployeeBox();
        }
    }

    
}
