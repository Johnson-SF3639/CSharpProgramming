using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorkLog
{
    public class Attendances
    {
        public DateTime Date { get; set; }
        public int NumberOfHoursWorked { get; set; }

        public Attendances(DateTime date, int numberOfHoursWorked){
            Date= date;
            NumberOfHoursWorked = numberOfHoursWorked;
        }

    }
}