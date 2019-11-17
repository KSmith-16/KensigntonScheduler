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
            
        };

        public struct day
        {
            public string name;
            public int splashShifts;//1 in shift index
            public int maintenceShiftsDay;//2
            public int maintenceShiftsNight;//3
            public List<int> e_index;
            public List<int> shift_index;
            public int managerShift;//4
        }

        public List<Employee> employees = new List<Employee>();
        public List<day> days = new List<day>();

        public schedule()
        {
            importEmployees();//can use this function to import the employee list
        }

        public void CreateSchedule()//cretes and saves the current schedule. randomizes it each time
        {
            days.Clear();
            importEmployees();

            for (int i = 0; i < 7; i++)
            {
                
                day currentDay = new day();
                currentDay.name = dayAssigner(i);
                currentDay.e_index = new List<int>();
                currentDay.shift_index = new List<int>();
                Random randomGen = new Random();
                if (i == 0)///////////should be npt here
                    //what the fuck does the previous comment mean
                    //anyway: problem is that workers have greater > 40 hours but not enough workers to fill the chedule so itsin an infiinte loop
                {
                    currentDay.maintenceShiftsDay = 2;
                    currentDay.maintenceShiftsNight = 2;
                    currentDay.splashShifts = 5;
                    currentDay.managerShift = 2;
                    for (int j = 0; j < 2; j++)//day shift
                    {
                        int randNum = randomGen.Next(0, employees.Count);

                        if (employees[randNum].hours <= 32)
                        {
                            Employee temp = new Employee();
                            temp.firstName = employees[randNum].firstName;
                            temp.lastName = employees[randNum].lastName;
                            temp.superviser = employees[randNum].superviser;
                            temp.manager = employees[randNum].manager;
                            temp.hours = employees[randNum].hours + 8;
                            employees[randNum] = temp;

                            currentDay.e_index.Add(randNum);
                            currentDay.shift_index.Add(2);
                        }
                        else
                        {
                            j--;
                        }
                    }
                    for (int j = 0; j < 2; j++)//night shift
                    {
                        int randNum = randomGen.Next(0, employees.Count);

                        if (employees[randNum].hours <= 32)
                        {
                            Employee temp = new Employee();
                            temp.firstName = employees[randNum].firstName;
                            temp.lastName = employees[randNum].lastName;
                            temp.superviser = employees[randNum].superviser;
                            temp.manager = employees[randNum].manager;
                            temp.hours = employees[randNum].hours + 8;
                            employees[randNum] = temp;

                            currentDay.e_index.Add(randNum);
                            currentDay.shift_index.Add(3);
                        }
                        else
                        {
                            j--;
                        }
                    }
                    for (int j = 0; j < 5; j++)//splash shift
                    {
                        int randNum = randomGen.Next(0, employees.Count);

                        if (employees[randNum].hours <= 32)
                        {
                            Employee temp = new Employee();
                            temp.firstName = employees[randNum].firstName;
                            temp.lastName = employees[randNum].lastName;
                            temp.superviser = employees[randNum].superviser;
                            temp.manager = employees[randNum].manager;
                            temp.hours = employees[randNum].hours + 8;
                            employees[randNum] = temp;

                            currentDay.e_index.Add(randNum);
                            currentDay.shift_index.Add(1);
                        }
                        else
                        {
                            j--;
                        }
                    }
                    for (int j = 0; j < 2; j++)//manager shift
                    {
                        int randNum = randomGen.Next(0, employees.Count);

                        if (employees[randNum].manager)
                        {
                            Employee temp = new Employee();
                            temp.firstName = employees[randNum].firstName;
                            temp.lastName = employees[randNum].lastName;
                            temp.superviser = employees[randNum].superviser;
                            temp.manager = employees[randNum].manager;
                            temp.hours = employees[randNum].hours + 8;
                            employees[randNum] = temp;

                            currentDay.e_index.Add(randNum);
                            currentDay.shift_index.Add(4);
                        }
                        else
                        {
                            j--;
                        }
                    }
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
            schedule.Close();
        }

        public void importEmployees()
        {
            employees.Clear();
            var EmployeesReader = new StreamReader(File.OpenRead("Employees.txt"));
            EmployeesReader.ReadLine();

            while (!(EmployeesReader.EndOfStream))
            {
                string line = EmployeesReader.ReadLine();
                int spaces = 0;

                Employee currentEmployee = new Employee();
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
