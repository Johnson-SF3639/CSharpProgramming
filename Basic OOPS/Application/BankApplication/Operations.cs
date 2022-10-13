using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Operations
    {
        static BankAccountDetails currentCustomer= null;
        static List<BankAccountDetails> bankAccount = new List<BankAccountDetails>();
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

                Console.WriteLine($"Enter The Name :");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter The Father Name :");
                string fatherName = Console.ReadLine();

                Console.WriteLine($"Enter The Gender :");
                Gender gender =Enum.Parse<Gender>(Console.ReadLine(),true);

                Console.WriteLine($"Enter The Date of Birth :");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

                Console.WriteLine($"Enter The Account Type :");
                AccountType accountType =Enum.Parse<AccountType>(Console.ReadLine(),true);

                BankAccountDetails Details = new BankAccountDetails(name, fatherName,gender,dob,accountType);

                bankAccount.Add(Details);
                Console.WriteLine($"Your Register Number : {Details.AccountNumber}");
        }
        public static void Login()
        {
            Console.WriteLine($"Enter Your Account Number");
            int AccountNumber =int.Parse(Console.ReadLine().ToUpper());

            foreach (BankAccountDetails customer in bankAccount)
            {
                if (customer.AccountNumber == AccountNumber)
                {
                    Console.WriteLine($"Login Successfull");
                    currentCustomer = customer;
                    SubMenu();
                }
            }
        }
        public static void SubMenu(){
            string pass = "Yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice :\n1. Show Details\n2. Deposit\n3. Withdrawl\n4. Show Balance \n5. Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"1. Show Details");
                            currentCustomer.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"2. Deposit");
                            currentCustomer.Deposit();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"3. Withdrawl");
                            currentCustomer.Withdrawl();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"4. Show Balance");
                            currentCustomer.ShowBalance();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"5. Exit Sub Menu");
                            pass = "No";
                            break;
                        }
                }
            } while (pass == "Yes");
        }
    
    }
}