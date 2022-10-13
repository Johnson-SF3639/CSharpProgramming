using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID = 2000;
        public string CustomerID { get; set; }
        public double Balance { get; set; }

        public CustomerDetails(string name, string fatherName, Gender gender, long phone) : base (name, fatherName, gender, phone){
            s_customerID++;
            CustomerID = "CID"+ s_customerID;
        }
        public void Recharge(){
            Console.WriteLine($"Enter your Amount");
            Balance += double.Parse(Console.ReadLine());
        }

        public void ShowCustomer(){
            Console.WriteLine($"\nCustomer Id {CustomerID}");
            ShowDetails();
            Console.WriteLine($"Your Balance is {Balance}"); 
        }
    }
}