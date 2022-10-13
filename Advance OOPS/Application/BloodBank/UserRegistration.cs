using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum Blood {Default, A_Positive, B_Positive, O_Positive, AB_Positive }
    public class UserDetails
    {
        private static int s_userId = 1000;
        public string UserID { get; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public Blood BloodGroup {get; set;}
        public int Age { get; set;}
        public DateTime LastDate { get; set; }

        public UserDetails(string userName, long mobileNumber, Blood bloodGroup, int age, DateTime lastDate){
            s_userId++;
            UserID ="UID"+ s_userId;
            UserName = userName;
            MobileNumber = mobileNumber;
            BloodGroup = bloodGroup;
            Age = age;
            LastDate = lastDate;
        }
        public UserDetails(string data){
            string[] value = data.Split(',');
            s_userId = int.Parse(value[0].Remove(0,3));
            UserID =value[0];
            UserName = value[1];
            MobileNumber =long.Parse(value[2]);
            BloodGroup = Enum.Parse<Blood>(value[3]);
            Age = int.Parse(value[4]);
            LastDate = DateTime.Parse(value[5]);
        }

        public bool GetDonationDetails(){
            // Console.WriteLine($"Enter your Weight : ");
            // double weight = double.Parse(Console.ReadLine());

            // Console.WriteLine($"Enter your Blood Pressure : ");
            // double bloodPressure = double.Parse(Console.ReadLine());

            // Console.WriteLine($"Enter your Hemoglobin Count : ");
            // double hemoglobinCount = double.Parse(Console.ReadLine());
            
            // if(weight >= 50.0 && bloodPressure >= 130.0 && hemoglobinCount >= 13.0){  
            //     return true;
            // }else{
                return false;
            // }
        }
        public int ShowNextEligiblityDate(){ 
                DateTime date = DateTime.Now; int count=0; int increase=0;
                while(true){
                    DateTime AddDate = date.AddDays(count);
                    string check1 = LastDate.ToShortDateString();
                    string check2 = AddDate.ToShortDateString();
                    if(check1 == check2 ){
                        return increase;
                    }
                    count--;
                    increase++;
                }
        }
    }
}