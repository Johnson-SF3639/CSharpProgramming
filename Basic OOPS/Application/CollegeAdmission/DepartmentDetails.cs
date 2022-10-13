using System;

namespace CollegeAdmission
{
    public class DepartmentDetails 
    {
        private static int s_deptId = 100;
        public string DepartmentId { get; }
        public string DepartmentName { get; set; }
        public int NoOfSeat { get; set;}

        public DepartmentDetails(string departmentName, int noOfSeat){
            s_deptId++;
            DepartmentId = "DID" +s_deptId;
            DepartmentName = departmentName;
            NoOfSeat= noOfSeat;
        }

        public DepartmentDetails(string data){
            string[] value = data.Split(',');
            s_deptId = int.Parse(value[0].Remove(0,5));
            DepartmentId = value[0];
            DepartmentName = value[1];
            NoOfSeat = int.Parse(value[2]);
        }
    }
}