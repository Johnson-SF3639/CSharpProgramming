using System;
using System.Collections.Generic;
using EmployeeLibrary;

namespace EmployeeOperation
{
    public class Operation
    {
        public static void MainMenu()
        {
            string pass;
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>();

            do
            {

                Console.WriteLine($"Enter the Employee Name :");
                string employeeName = Console.ReadLine();

                Console.WriteLine($"Enter the Employee Role : ");
                string employeeRole = Console.ReadLine();

                Console.WriteLine($"Enter the Gender :");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

                Console.WriteLine($"Enter the Work Location :");
                WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(), true);

                Console.WriteLine($"Enter the Team Name :");
                string teamName = Console.ReadLine();

                Console.WriteLine($"Enter the Date of Join :");
                DateTime dateOfJoin = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

                Console.WriteLine($"Enter the Working Day(In Month) :");
                int workingDays = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter the No of Leave : ");
                int leaves = Convert.ToInt32(Console.ReadLine());

                EmployeeDetails employeeDetails = new EmployeeDetails(employeeName, employeeRole, gender, workLocation, teamName, dateOfJoin, workingDays, leaves);

                employeeList.Add(employeeDetails);

                Console.WriteLine($"Do you want to see another Details (Yes/No): ");
                pass = Console.ReadLine();
            } while (pass == "yes");

            foreach(EmployeeDetails employee in employeeList){
                Console.WriteLine($"\nYour ID : {employee.EmployeeID}");
                Console.WriteLine($"Your Name : {employee.EmployeeName}");
                Console.WriteLine($"Your Role : {employee.EmployeeRole}");
                Console.WriteLine($"Your Gender : {employee.Gender}");
                Console.WriteLine($"Your Work Location : {employee.WorkLocation}");
                Console.WriteLine($"Your Team Name : {employee.TeamName}");
                Console.WriteLine($"Your Date of Join : {employee.DateOfJoin}");
                Console.WriteLine($"Your Working Days : {employee.WorkingDays}");
                Console.WriteLine($"Your No of Leaves : {employee.Leaves}");
                employee.CalculateSalary();
            }


        }
    }
}