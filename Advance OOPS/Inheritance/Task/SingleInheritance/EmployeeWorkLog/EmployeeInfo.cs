using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWorkLog
{
    public enum Gendar{Default, Male, Female}
    public class EmployeeInfo : SalaryInfo
    {
        private static int s_employeeId = 1000;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gendar Gendar { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }        
        public List<Attendances> attendancesList {get; set;}

        public EmployeeInfo(string name, string fatherName, Gendar gender, long mobile, DateTime dob, string branch,int salaryOfTheMonth, int month) : base(salaryOfTheMonth, month){
            s_employeeId++;
            EmployeeID ="EID"+ s_employeeId;
            Name = name;
            FatherName =fatherName;
            Gendar = gender;
            Mobile = mobile;
            DOB = dob;
            Branch = branch;
            attendancesList = new List<Attendances>();
        }

        public void ShowEmployeeDetails(){
            Console.WriteLine($"{EmployeeID}\t{Name}\t{FatherName}\t{Gendar}\t{Mobile}\t{DOB.ToShortDateString()}\t{Branch}\t{SalaryOfTheMonth}\t{Month}");
            Console.WriteLine($"\nDate\tNumberOfHoursWorked");
            foreach(Attendances attendances in attendancesList){
                Console.WriteLine($"{attendances.Date.ToShortDateString()}\t{attendances.NumberOfHoursWorked}");
            }
        }

    }
}