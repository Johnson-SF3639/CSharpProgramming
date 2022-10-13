using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountDetails
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountNo = 100002500;
        public int AccountNumber { get; set; }
        public string  BranchName { get; set; }
        public string  IFSCCode { get; set; }
        public double  Balance { get; set; }
        
        public AccountInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, string branchName, string iFSCCode, int balance) : base(name, fatherName, phone, mail, dob, gender){
            s_accountNo++;
            AccountNumber= s_accountNo;
            BranchName = branchName;
            IFSCCode = iFSCCode;
            Balance = balance;
        }

        public void ShowAccountInfo(){
            Console.WriteLine($"{Name}\t{AccountNumber}\t{BranchName}\t{IFSCCode}\t{Balance}\t{Phone}\t{Mail}");
        }
    }
}