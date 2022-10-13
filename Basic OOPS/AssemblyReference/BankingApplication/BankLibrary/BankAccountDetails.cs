using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLibrary
{
    public enum Gender {Default,Male,Female,Transgender};
    public enum AccountType {Default,SB,FD,RD};
    public class BankAccountDetails
    {
        private static int s_accountNumber=10000;
        public int AccountNumber { get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public AccountType AccountType { get; set; }   
        public double Balance { get; set; }
        
        
        
        
        public BankAccountDetails(string name, string fatherName,Gender gender,DateTime dob, AccountType accountType){
            s_accountNumber++;
            AccountNumber=s_accountNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
            Balance=0;
        }

        public void Deposit(){
            Console.WriteLine($"Enter the Deposit Amount");
            double deposit =Convert.ToInt32(Console.ReadLine());
            Balance = Balance+deposit;
        }
         public void Withdrawl(){
            Console.WriteLine($"Enter the Withdrawl Amount");
            double withDrawl = Convert.ToInt32(Console.ReadLine());
            Balance = Balance-withDrawl;
         }
         public void ShowBalance(){
            Console.WriteLine($"See your Balance Amount is : {Balance}");
         }
    }
}