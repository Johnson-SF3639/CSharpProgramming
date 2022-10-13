using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankOperations
{
    public class Operations
    {
        public static void MainMenu()
        {

            List<BankAccountDetails> bankAccount = new List<BankAccountDetails>();
            string pass = "";

            do
            {
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

                Console.WriteLine($"Do you want Add another Details (Yes/No) : ");
                pass = Console.ReadLine().ToLower();
            } while (pass == "yes");

            foreach (BankAccountDetails accountInfo in bankAccount)
            {
                Console.WriteLine("\nAccount Details");
                Console.WriteLine($"The Account No : {accountInfo.AccountNumber}");
                Console.WriteLine($"The Name : {accountInfo.Name}");
                Console.WriteLine($"The Father Name : {accountInfo.FatherName}");
                Console.WriteLine($"Your Gender : {accountInfo.Gender}");
                Console.WriteLine($"Your Date of Birth : {accountInfo.DOB.ToShortDateString()}");
                Console.WriteLine($"The Account Type : {accountInfo.AccountType}");
                Console.WriteLine($"The Account Balance : {accountInfo.Balance}");
                accountInfo.Deposit();
                accountInfo.Withdrawl();
                accountInfo.ShowBalance();
            }

        }
    }
}