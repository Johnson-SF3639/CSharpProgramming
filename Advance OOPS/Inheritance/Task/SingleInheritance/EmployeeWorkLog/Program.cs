using System;
namespace EmployeeWorkLog{
    class Program{
        public static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo("John","Rajan",Gendar.Male,0988766,DateTime.Now,"Tuty",30,30);
            Attendances attendances = new Attendances(DateTime.Today,8);
            employee.attendancesList.Add(attendances);
            
            Console.WriteLine($"\nEmployeeID\tName\tFatherName\tGendar\tMobile\tDOB\tBranch\tSalaryOfTheMonth\tMonth");
            employee.ShowEmployeeDetails();
            Console.WriteLine($"\n");
            
        }
    }
}