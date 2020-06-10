using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KensigntonScheduler
{
    public struct DaysOff
    {
        int employeeIndex;
        List<int> off; //since we can only have day off or not, we can just have each int be a day off.
    }
    class Calendar
    {
        //use file system to store current date and peoples needed days off
        //hesavily apart of the other class with no real checks. 
        //class employees by their index but be sure to update when employees are deleted or added
        //file format:
        /*
         * date(month/day) day of week (monday, tuesday, wednesday, etc)
         * employee index
         *          date off(monht/day) day of week. if none leave blank
         * employee index
         * employee index
         * */

        List<DaysOff> daysOff = new List<DaysOff>();

        public Calendar()
        {
        }

        public void importSchedule()
        { }
        public void exportSchedule()
        { }
        public void deleteEmployee(int ind)
        { }
        public List<DaysOff> getDaysOff()
        {
            return daysOff;
        }
    }
}
