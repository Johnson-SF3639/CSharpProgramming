using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerces
{
    public class CustomerDetails
    {
        private static int s_customerId =1000;
        public string CustomerId { get; }
        public string CustomerName {get; set;}
        public string City { get; set; }  
        public long MobileNumber { get; set; } 
        public double WalletBalance {get; set;}
        public string EmailId {get; set;}
    
        public CustomerDetails(string customerName, string city, long mobileNumber, double walletBalance, string emailId){
            s_customerId++;
            CustomerId ="CID"+s_customerId;
            CustomerName = customerName;
            City = city;
            MobileNumber = mobileNumber;
            WalletBalance = walletBalance;
            EmailId = emailId;
        }
        public CustomerDetails(string data){
            string[] value = data.Split(',');
            s_customerId = int.Parse(value[0].Remove(0,3));
            CustomerId =value[0];
            CustomerName = value[1];
            City = value[2];
            MobileNumber = long.Parse(value[3]);
            WalletBalance = double.Parse(value[4]);
            EmailId = value[5];
        }

        public void ShowDetails(){
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"Customer City : {City}");
            Console.WriteLine($"Customer Wallet Balance : {WalletBalance}");
            Console.WriteLine($"Customer Mobile Number : {MobileNumber}");
            Console.WriteLine($"Customer Mail Id : {EmailId}");
        }
        public void RechargeWallet(){
            Console.WriteLine($"Enter you Deposit Amount");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance = WalletBalance + amount;
        }


    }
}