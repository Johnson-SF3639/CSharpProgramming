using System;

namespace EmployeeLibrary
{
    public enum WorkLocation { Default, Madura, Eymard };
    public enum Gender { Default, Male, Female };
    public class EmployeeDetails
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get;}
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public Gender Gender { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoin { get; set; }
        public int WorkingDays { get; set; }
        public int Leaves { get; set; }
        
        public EmployeeDetails(string employeeName, string employeeRole, Gender gender, WorkLocation workLocation, string teamName, DateTime dateOfJoin, int workingDays, int leaves){
            s_employeeID++;
            EmployeeID = "SF" + s_employeeID;
            EmployeeName = employeeName;
            EmployeeRole = employeeRole;
            Gender = gender;
            WorkLocation = workLocation;
            TeamName = teamName;
            DateOfJoin = dateOfJoin;
            WorkingDays = workingDays;
            Leaves = leaves;
        }

        public void CalculateSalary(){
            WorkingDays = (WorkingDays-Leaves)*500;
            Console.WriteLine($"The Employee Salary is : {WorkingDays}\n");
            
        }
    }
}