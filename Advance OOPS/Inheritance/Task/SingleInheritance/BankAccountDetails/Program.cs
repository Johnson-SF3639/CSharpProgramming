using System;
namespace BankAccountDetails{
    class Program{
        public static void Main(string[] args)
        {
            AccountInfo accountInfo = new AccountInfo("John","Rajan",9345564,"John@gmail.com",DateTime.Now,Gender.Male,"Tuticorin","IOBA1002304",10000);
            Console.WriteLine($"\nName\tAccountNumber\tBranchName\tIFSCCode\tBalance\tPhone\tMail");
            accountInfo.ShowAccountInfo();
            Console.WriteLine($"\n");
            
        }

    }
}