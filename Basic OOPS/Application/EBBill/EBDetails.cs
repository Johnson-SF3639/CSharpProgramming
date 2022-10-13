using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBill
{
    public class EBDetails
    {
        private static int s_meterID = 1000;
        public string MeterID { get; }
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public int Unit { get; set; }
        
        public EBDetails(string userName, long phoneNumber, string mailID, int unit){
            s_meterID++;
            MeterID = "EB" + s_meterID;
            UserName = userName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            Unit = unit;
        }

        public void ShowDetails(){
                Console.WriteLine($"\nYour ID : {MeterID}");
                Console.WriteLine($"Your Name : {UserName}");
                Console.WriteLine($"Your Phone Number : {PhoneNumber}");
                Console.WriteLine($"Your Mail ID : {MailID}");
                Console.WriteLine($"Your Unit : {Unit}");
        }
        public void GetNoUnit(){
                Console.WriteLine($"Enter Your Unit :");
                Unit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your Unit is : {Unit}");
        }
        public void CalculateAmount(){
            if(Unit <= 100){
                Console.WriteLine($"Your EB Amout FREE");
            }else if(Unit >100 && Unit <200){
                Console.WriteLine($"Your EB Amount is {Unit*3}");
            }else if(Unit >200 && Unit <400){
                Console.WriteLine($"Your EB Amount is {Unit*5}");
            }else{
                Console.WriteLine($"Your EB Amount is {Unit*6}");
            }
        }
    }
}