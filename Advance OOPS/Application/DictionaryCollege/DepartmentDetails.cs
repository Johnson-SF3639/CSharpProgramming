using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class DepartmentDetails
    {
        private static int s_departmentId = 100;
        public string DepartmentId { get; set; }
        public string DepartmentName {get; set;}
        public int NumberOfSeats {get; set;}

        public DepartmentDetails(string departmentName, int numberOfSeats){
            s_departmentId++;
            DepartmentId = "DID"+s_departmentId;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

    }
}