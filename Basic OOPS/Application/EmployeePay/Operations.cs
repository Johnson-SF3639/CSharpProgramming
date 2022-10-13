using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePay
{
    public class Operations
    {
        static EmployeeDetails currentEmployee =null;
        static List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
        public static void MainMenu(){
            string choice = "Yes";
            do
            {
                Console.WriteLine($"\nSelect Your Option To Action \n1. Registretion\n2. Login\n3. Exit\n");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine($"Registretion");
                            Registretion();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exit");
                            choice = "No";
                            break;
                        }
                }
            } while (choice == "Yes");
        }
        public static void Registretion(){

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
                
            Console.WriteLine($"Your Employee ID : {employeeDetails.EmployeeID}");
        }
        
        public static void Login()
        {
            Console.WriteLine($"Enter Your Register Number");
            string employeeId = Console.ReadLine().ToUpper();

            foreach (EmployeeDetails employee in employeeList)
            {
                if (employee.EmployeeID == employeeId)
                {
                    Console.WriteLine($"Login Successfull");
                    currentEmployee = employee;
                    SubMenu();
                }
            }
        }
        public static void SubMenu(){
            string pass = "Yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice :\n1. Show Details\n2. Get The Number of Leaves\n3. Calculate Bill \n4. Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"1. Show Details");
                            currentEmployee.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Number of Leave");
                            currentEmployee.GetNoLeaves();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"3. Calculate Salary");
                            currentEmployee.CalculateSalary();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Exit Sub Menu");
                            pass = "No";
                            break;
                        }
                }
            } while (pass == "Yes");

        }
    }
}