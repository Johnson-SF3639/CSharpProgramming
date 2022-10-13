using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Files
    {
        public static void Create(){
            try{
                
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Folder Created");
                Directory.CreateDirectory("Details");               
            }

            if(!File.Exists("Details/Donation.csv")){
                Console.WriteLine($"File Created Successfully");
                File.Create("Details/Donation.csv");             
            }

            if(!File.Exists("Details/Registeration.csv")){
                Console.WriteLine($"File Created Successfully");
                File.Create("Details/Registeration.csv");
            } 
            }catch(DirectoryNotFoundException e){
                Console.WriteLine($"Error : {e}");
            }
        }

        public static void ReadFile(){

            string[] donationDetails = File.ReadAllLines("Details/Donation.csv");
            foreach(string data in donationDetails){
                Donation donation = new Donation(data);
                Operations.donationList.Add(donation);
            }
            
            string[] registerationDetails = File.ReadAllLines("Details/Registeration.csv");
            foreach(string data in registerationDetails){
                UserDetails registeration = new UserDetails(data);
                Operations.userList.Add(registeration);
            }
        }

        public static void WriteFile(){
            string[] donation = new string[Operations.donationList.Count];
            for(int i=0; i<Operations.donationList.Count; i++){
                donation[i]= Operations.donationList[i].DonationId +","+  Operations.donationList[i].DonationDate  +","+  Operations.donationList[i].Weight  +","+  Operations.donationList[i].BloodPressure  +","+  Operations.donationList[i].HemoglobinCount ;
            }
            File.WriteAllLines("Details/Donation.csv",donation);

            string[] registeration = new string[Operations.userList.Count];
            for(int i=0; i<Operations.userList.Count; i++){
                registeration[i] = Operations.userList[i].UserID +","+ Operations.userList[i].UserName +","+ Operations.userList[i].MobileNumber +","+ Operations.userList[i].BloodGroup +","+ Operations.userList[i].Age +","+Operations.userList[i].LastDate;
            }
            File.WriteAllLines("Details/Registeration.csv",registeration);
        }
    }
}