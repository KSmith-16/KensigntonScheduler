using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KensigntonScheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    
    public class schedule
    {
        public struct Employee
        {
            public int hours;
            public bool superviser;
            public bool manager;
            public string firstName;
            public string lastName;
            public int index;
            
        };

        public struct day
        {
            public string name;
            public int splashShifts;//1 in shift index
            public int maintenceShiftsDay;//2 
            public int maintenceShiftsNight;//3
            public List<int> e_index;//employees working this day
            public List<int> shift_index;//shift employee is working, its index correlates to the list above
            public int managerShift;//4
            //shift variabl;es used to say how many of eacfh shift is in a specfic day 
        }

        public List<Employee> employees = new List<Employee>();
        public List<day> days = new List<day>();

        public schedule()
        {
            importEmployees();//can use this function to import the employee list
        }

        public void CreateSchedule()//creates and saves the current schedule. randomizes it each time
        {
            days.Clear();
            importEmployees();
            Random randomGen = new Random();

            for (int i = 0; i < 7; i++)//iterates through each day
            {
                
                day currentDay = new day();
                currentDay.name = dayAssigner(i);
                currentDay.e_index = new List<int>();
                currentDay.shift_index = new List<int>();
                
                    currentDay.maintenceShiftsDay = 2;
                    currentDay.maintenceShiftsNight = 2;
                    currentDay.splashShifts = 5;
                    currentDay.managerShift = 2;
                List<Employee> currentEmployee = new List<Employee>();
                for (int e = 0; e < employees.Count; e++)
                {
                    if (employees[e].hours < 33)
                    {
                        currentEmployee.Add(employees[e]);
                    }
                }

                for (int j = 0; j < currentDay.managerShift; j++)
                {
                    int ran = randomGen.Next(currentEmployee.Count);
                    Employee temp = currentEmployee[ran];
                    if (temp.manager)
                    {
                        temp.firstName = currentEmployee[ran].firstName;
                        temp.lastName = currentEmployee[ran].lastName;
                        temp.superviser = currentEmployee[ran].superviser;
                        temp.manager = currentEmployee[ran].manager;
                        temp.hours = currentEmployee[ran].hours + 8;
                        temp.index = currentEmployee[ran].index;

                        currentDay.e_index.Add(temp.index);
                        currentDay.shift_index.Add(4);
                        currentEmployee.RemoveAt(ran);
                        employees[temp.index] = temp;
                    }
                    else
                    {
                        j--;
                    }
                }
                for (int j = 0; j < currentDay.maintenceShiftsDay; j++)
                {
                    int ran = randomGen.Next(currentEmployee.Count);
                    Employee temp = currentEmployee[ran];
                    temp.firstName = currentEmployee[ran].firstName;
                    temp.lastName = currentEmployee[ran].lastName;
                    temp.superviser = currentEmployee[ran].superviser;
                    temp.manager = currentEmployee[ran].manager;
                    temp.hours = currentEmployee[ran].hours + 8;
                    temp.index = currentEmployee[ran].index;

                    currentDay.e_index.Add(temp.index);
                    currentDay.shift_index.Add(2);
                    currentEmployee.RemoveAt(ran);
                    employees[temp.index] = temp;
                }
                for (int j = 0; j < currentDay.maintenceShiftsNight; j++)
                {
                    int ran = randomGen.Next(currentEmployee.Count);
                    Employee temp = currentEmployee[ran];
                    temp.firstName = currentEmployee[ran].firstName;
                    temp.lastName = currentEmployee[ran].lastName;
                    temp.superviser = currentEmployee[ran].superviser;
                    temp.manager = currentEmployee[ran].manager;
                    temp.hours = currentEmployee[ran].hours + 8;
                    temp.index = currentEmployee[ran].index;

                    currentDay.e_index.Add(temp.index);
                    currentDay.shift_index.Add(3);
                    currentEmployee.RemoveAt(ran);
                    employees[temp.index] = temp;
                }

                for (int j = 0; j < currentDay.splashShifts; j++)
                {
                    int ran = randomGen.Next(currentEmployee.Count);
                    Employee temp = new Employee();

                    temp.firstName = currentEmployee[ran].firstName;
                    temp.lastName = currentEmployee[ran].lastName;
                    temp.superviser = currentEmployee[ran].superviser;
                    temp.manager = currentEmployee[ran].manager;
                    temp.hours = currentEmployee[ran].hours + 8;
                    temp.index = currentEmployee[ran].index;

                    currentDay.e_index.Add(temp.index);
                    currentDay.shift_index.Add(1);
                    currentEmployee.RemoveAt(ran);
                    employees[temp.index] = temp;
                }

                days.Add(currentDay);
                
            }

            writeToFile();
        }

        public void writeToFile()//writes schedule to file
        {
            var schedule = new StreamWriter(@"Schedule.txt",false);
            for (int i = 0; i < 7; i++)
            {
                schedule.WriteLine(days[i].name);
                schedule.WriteLine("    Splash Shifts: ");
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 1)
                    {
                        schedule.WriteLine("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName);
                    }
                }
                schedule.WriteLine("    Maintence Shifts(6am): ");
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 2)
                    {
                        schedule.WriteLine("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName);
                    }
                }

                schedule.WriteLine("    Maintence Shifts(2pm): ");
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 3)
                    {
                        schedule.WriteLine("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName);
                    }
                }
                schedule.WriteLine("    Managers: ");
                for (int j = 0; j < days[i].shift_index.Count; j++)
                {
                    if (days[i].shift_index[j] == 4)
                    {
                        schedule.WriteLine("        " + employees[days[i].e_index[j]].firstName + " " + employees[days[i].e_index[j]].lastName);
                    }
                }

            }

            for (int i = 0; i < employees.Count; i++)
            {
                schedule.WriteLine($"{employees[i].firstName}: {employees[i].hours}");
            }
            schedule.Flush();
            schedule.Close();
        }

        public void importEmployees()
        {
            employees.Clear();
            var EmployeesReader = new StreamReader(File.OpenRead("Employees.txt"));
            EmployeesReader.ReadLine();
            int index = 0;

            while (!(EmployeesReader.EndOfStream))
            {
                string line = EmployeesReader.ReadLine();
                int spaces = 0;

                
                Employee currentEmployee = new Employee();
                currentEmployee.index = index;
                index++;

                currentEmployee.firstName = "";
                currentEmployee.lastName = "";
                currentEmployee.manager = false;
                currentEmployee.superviser = false;
                currentEmployee.hours = 0;
                //char last = line.Last();
                for (int i = 0; i < line.Count(); i++)
                {
                    if (line[i] == ' ')
                    {
                        spaces++;
                    }
                    else
                    {
                        if (spaces == 0)
                        {
                            currentEmployee.firstName += line[i];
                        }
                        else if (spaces == 1)
                        {
                            currentEmployee.lastName += line[i];
                        }
                        else if (spaces == 2)
                        {
                            if (line[i] == 'Y' || line[i] == 'y')
                            {
                                currentEmployee.superviser = true;
                            }
                        }
                        else if (spaces == 3)
                        {
                            if (line[i] == 'Y' || line[i] == 'y')
                            {
                                currentEmployee.superviser = true;
                                currentEmployee.manager = true;
                            }
                        }
                    }
                }
                employees.Add(currentEmployee);
            }
            EmployeesReader.DiscardBufferedData();
            EmployeesReader.Close();
        }

        public string dayAssigner(int i)
        {
            string answer = "";
            switch (i)
            {
                case 0:
                    answer = "Monday";
                    break;
                case 1:
                    answer = "Tuesday";
                    break;
                case 2:
                    answer = "Wednesday";
                    break;
                case 3:
                    answer = "Thursday";
                    break;
                case 4:
                    answer = "Friday";
                    break;
                case 5:
                    answer = "Saturday";
                    break;
                case 6:
                    answer = "Sunday";
                    break;
            }
            return answer;
        }
    }
}
