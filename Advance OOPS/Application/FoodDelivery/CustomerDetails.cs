using System;

namespace FoodDelivery
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static int s_customerId =1000;
        public string  CustomerID { get; set; }
        public double  WalletBalance { get; set; }

        public CustomerDetails(){

        }

        public CustomerDetails(string name, string fatherName, Gender gender,long mobileNumber, DateTime dob, string mailID, string location, double walletBalance) : base(name, fatherName, gender,mobileNumber, dob, mailID, location){
            s_customerId++;
            CustomerID = "CID"+s_customerId;
            WalletBalance = walletBalance;
        }
        
        public CustomerDetails(string data){
            string[] value = data.Split(','); 
            s_customerId = int.Parse(value[0].Remove(0,3));
            CustomerID = value[0]; 
            Name=value[1];
            FatherName = value[2];
            Gender= Enum.Parse<Gender>(value[3]);
            MobileNumber = long.Parse(value[4]);
            DOB = DateTime.Parse(value[5]);
            MailID = value[6];
            Location = value[7];
            WalletBalance = double.Parse(value[8]);
        }

        public void ShowCustomerDetails(){

        }

        public void WalletRecharge(){
            Console.WriteLine($"Your Balance is : {WalletBalance}\nEnter the amount to Recharge : ");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance += amount;
            Console.WriteLine($"Your Balance is : {WalletBalance}");
        }
    }
}