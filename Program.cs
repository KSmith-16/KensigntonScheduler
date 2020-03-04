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
    public class schedule
    {
        

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
                dayAssigner(i, ref currentDay);
                currentDay.e_index = new List<int>();
                currentDay.shift_index = new List<int>();
                
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
                    if (temp.manager || temp.superviser)
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

        public void dayAssigner(int i, ref day tempDay)
        {
            if (i == 0)//monday
            {
                tempDay.name = "Monday";
                tempDay.splashShifts = 5;
                tempDay.maintenceShiftsDay = 3;
                tempDay.maintenceShiftsNight = 2;
                tempDay.managerShift = 1;
            }
            else if (i == 1)
            {
                tempDay.name = "Tuesday";
                tempDay.splashShifts = 5;
                tempDay.maintenceShiftsDay = 2;
                tempDay.maintenceShiftsNight = 2;
                tempDay.managerShift = 1;
            }
            else if (i == 2)
            {
                tempDay.name = "Wednesday";
                tempDay.splashShifts = 5;
                tempDay.maintenceShiftsDay = 2;
                tempDay.maintenceShiftsNight = 2;
                tempDay.managerShift = 1;
            }
            else if (i == 3)
            {
                tempDay.name = "Thursday";
                tempDay.splashShifts = 5;
                tempDay.maintenceShiftsDay = 2;
                tempDay.maintenceShiftsNight = 2;
                tempDay.managerShift = 1;
            }
            else if (i == 4)
            {
                tempDay.name = "Friday";
                tempDay.splashShifts = 6;
                tempDay.maintenceShiftsDay = 2;
                tempDay.maintenceShiftsNight = 3;
                tempDay.managerShift = 2;
            }
            else if (i == 5)
            {
                tempDay.name = "Saturday";
                tempDay.splashShifts = 7;
                tempDay.maintenceShiftsDay = 3;
                tempDay.maintenceShiftsNight = 3;
                tempDay.managerShift = 2;
            }
            else if (i == 6)
            {
                tempDay.name = "Sunday";
                tempDay.splashShifts = 7;
                tempDay.maintenceShiftsDay = 3;
                tempDay.maintenceShiftsNight = 3;
                tempDay.managerShift = 2;
            }
        }

        public List<day> getDays()
        {
            return days;
        }

        public List<Employee> getEmployees()
        {
            return employees;
        }

        public void addEmployee(String firstName, String lastName, int pos)//pos 1 for neither, 2 supervisor, 3 manager
        {
            Employee tempEmployee = new Employee();
            tempEmployee.firstName = firstName;
            tempEmployee.lastName = lastName;
            tempEmployee.index = employees.Count  + 1;
            tempEmployee.hours = 0;
            if (pos == 1)
            {
                tempEmployee.superviser = false;
                tempEmployee.manager = false;
            }
            else if (pos == 2)
            {
                tempEmployee.superviser = true;
                tempEmployee.manager = false;
            }
            else 
            {
                tempEmployee.superviser = true;
                tempEmployee.manager = true;
            }

            employees.Add(tempEmployee);

            exportEmployees();
        }

        private void exportEmployees()
        {
            var employeeWriter = new StreamWriter(@"Employees.txt", false);
            employeeWriter.Flush();
            employeeWriter.WriteLine("FirstName LastName supervisor(y/n) manager(y/n)//skips this line. dont delete");
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].manager)
                {
                    employeeWriter.WriteLine($"{employees[i].firstName} {employees[i].lastName} y y");
                }
                else if (employees[i].superviser)
                {
                    employeeWriter.WriteLine($"{employees[i].firstName} {employees[i].lastName} y n");
                }
                else 
                {
                    employeeWriter.WriteLine($"{employees[i].firstName} {employees[i].lastName} n n");
                }
            }

            employeeWriter.Flush();
            employeeWriter.Close();
        }

        public void deleteEmployee(int empIndex)
        {
            employees.RemoveAt(empIndex);
            for (int i = 0; i < employees.Count; i++)
            {
                Employee tempEmployee = new Employee();
                tempEmployee.firstName = employees[i].firstName;
                tempEmployee.lastName = employees[i].lastName;
                tempEmployee.index = i;
                tempEmployee.hours = 0;
                tempEmployee.manager = employees[i].manager;
                tempEmployee.superviser = employees[i].superviser;
                employees[i] = tempEmployee;
            }

            exportEmployees();
        }

        public void updateEmployee(int index, int pos)// 1 = neither, 2 = supervisor, 3 = manager
        {
                Employee tempEmployee = new Employee();
                tempEmployee.firstName = employees[index].firstName;
                tempEmployee.lastName = employees[index].lastName;
                tempEmployee.index = employees[index].index;
                tempEmployee.hours = employees[index].hours;
            if (pos == 1)
            {
                tempEmployee.manager = false;
                tempEmployee.superviser = false;
            }
            else if (pos == 2)
            {
                tempEmployee.manager = false;
                tempEmployee.superviser = true;
            }
            else 
            {
                tempEmployee.manager = true;
                tempEmployee.superviser = true;
            }

                employees[index] = tempEmployee;
            exportEmployees();
           
        }

    }
}
