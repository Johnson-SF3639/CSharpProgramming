using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorkLog
{
    public class SalaryInfo
    {
        public int SalaryOfTheMonth { get; set; }
        public int Month { get; set; }

        public SalaryInfo(int salaryOfTheMonth, int month){
            SalaryOfTheMonth =salaryOfTheMonth;
            Month=month;
        }
    }
}