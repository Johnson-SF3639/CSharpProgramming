using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static int s_customerId = 1000;
        public string  CustomerID { get; set; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailId): base(name, fatherName, gender, mobile, dob, mailId){
            s_customerId++;
            CustomerID = "CID"+ s_customerId;
        }
        
        public CustomerDetails(string data){
            string[] value= data.Split(',');
            s_customerId = int.Parse(value[0].Remove(0,3));
            CustomerID = value[0];
            Name =value[1] ;
            FatherName = value[2];
            Gender =Enum.Parse<Gender>(value[3]);
            Mobile =long.Parse(value[4]);
            DOB = DateTime.Parse(value[5]);
            MailID = value[6];
            WalletBalance = double.Parse(value[7]);
        }

        public void ShowCustomerDetails(){
            Console.WriteLine($"{CustomerID}\t\t{Name,-10}{FatherName,-13}\t{Gender,-8}\t{Mobile,-10}\t{DOB.ToShortDateString(),-10}\t{MailID,-10}");
        }
        public void WalletRecharge(){
            Console.WriteLine($"Enter the Amount to Add the Wallet Balance");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance+=amount;  
            Console.WriteLine($"Your Balance Amount is : {WalletBalance}");          
        }
    }
}