using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePay
{
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

        public void ShowDetails(){
                Console.WriteLine($"\nYour ID : {EmployeeID}");
                Console.WriteLine($"Your Name : {EmployeeName}");
                Console.WriteLine($"Your Role : {EmployeeRole}");
                Console.WriteLine($"Your Gender : {Gender}");
                Console.WriteLine($"Your Work Location : {WorkLocation}");
                Console.WriteLine($"Your Team Name : {TeamName}");
                Console.WriteLine($"Your Date of Join : {DateOfJoin}");
                Console.WriteLine($"Your Working Days : {WorkingDays}");
                Console.WriteLine($"Your No of Leaves : {Leaves}");
        }

        public void GetNoLeaves(){
            Console.WriteLine($"Total Working Days : ");
            WorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter your Leave days : ");
            Leaves = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Working Days {WorkingDays} And Your No of Leaves : {Leaves}");
        }
        public void CalculateSalary(){
            Console.WriteLine($"Your Working Days {WorkingDays} And Your No of Leaves : {Leaves}");
            WorkingDays = (WorkingDays-Leaves)*500;
            Console.WriteLine($"The Employee Salary is : {WorkingDays}\n");
            
        }
    }
}