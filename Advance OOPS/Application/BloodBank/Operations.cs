using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Operations
    {
        static UserDetails loginUser = null;
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<Donation> donationList = new List<Donation>();
        public static void MainMenu(){
            string choice = "yes";
            do{
                Console.WriteLine($"\nEnter your Options :\n1. User Registration\n2. User Login\n3. Fetch Doner Details\n4. Exit");
                int action = int.Parse(Console.ReadLine());

                switch(action){
                    case 1:{
                        Console.WriteLine($"User Registration ");
                        Registration();
                        break;
                    }
                    case 2:{
                        Console.WriteLine($"User Login ");
                        Login();
                        break;
                    }
                    case 3:{
                        Console.WriteLine($"Fetch Donor Details  ");
                        FetchDonerDetails();
                        break;
                    }
                    case 4:{
                        Console.WriteLine($"Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice == "yes");
        }
        public static void Registration(){

            Console.WriteLine($"Enter your Donor Name : ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter your Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Mobile Number : ");
            long mobileNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Blood Group : ");
            Blood blood = Enum.Parse<Blood>(Console.ReadLine(),true); 

            Console.WriteLine($"Enter your Late Donation : ");
            DateTime lastDate = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

            UserDetails user = new UserDetails(name,mobileNumber,blood,age,lastDate);
            userList.Add(user);

            Console.WriteLine($"Your User ID is : {user.UserID}");
            
        }
        public static void Login(){

            Console.WriteLine($"Enter Your Registeration Id");
            string donerId = Console.ReadLine();  

            foreach(UserDetails user in userList){
                if(donerId == user.UserID){
                    Console.WriteLine($"Login Successfull");
                    loginUser = user;
                    SubMenu();                    
                }
            }   

        }
        public static void SubMenu(){
            string choice = "yes";
            do{
                Console.WriteLine($"\nEnter your Options :\n1. Donate Blood\n2. Donation History\n3. Next Eligible Date\n4. Exit");
                int action = int.Parse(Console.ReadLine());

                switch(action){
                    case 1:{
                        Console.WriteLine($"Donate Blood ");
                        DonateBlood();
                        break;
                    }
                    case 2:{
                        Console.WriteLine($"Donation History");
                        DonationHistory();
                        break;
                    }
                    case 3:{
                        Console.WriteLine($"Next Eligible Date ");
                        NextDayCheck();
                        break;
                    }
                    case 4:{
                        Console.WriteLine($"Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice == "yes");
        }
        public static void DonateBlood(){

            // Get weight, Blood Pressure, hemoglobin count
            Console.WriteLine($"Enter your Weight : ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Blood Pressure : ");
            double bloodPressure = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Hemoglobin Count : ");
            double hemoglobinCount = double.Parse(Console.ReadLine());

            if(weight >= 50.0 && bloodPressure >= 130.0 && hemoglobinCount >= 13.0){  
                //check eligiblity Date
                int increase = loginUser.ShowNextEligiblityDate();

                if(increase >= 60){
                    DateTime today = DateTime.Now;
                    loginUser.LastDate =  today;   
                    DateTime nextDate = today.AddDays(60);
                    Donation donate = new Donation(today, weight, bloodPressure, hemoglobinCount);   
                    donationList.Add(donate);
                    Console.WriteLine($"Blood donated successfully, \nYour donation ID is {donate.DonationId}. \nThe next eligible date of donation is {nextDate.ToShortDateString()} ");
                }
            }
        }
        public static void DonationHistory(){
            Console.WriteLine($"Your Donation History");
            Console.WriteLine($"DonationId  Weight  BloodPressure  HemoglobinCount");
            foreach(Donation donate in donationList){
                Console.WriteLine($"{donate.DonationId}\t{donate.Weight} \t  {donate.BloodPressure} \t\t {donate.HemoglobinCount}");
            }
        }
        public static void NextDayCheck(){
            DateTime day = loginUser.LastDate.AddDays(60);
            Console.WriteLine($"The next eligible date of donation is {day.ToShortDateString()}");   
        }
        public static void FetchDonerDetails(){
            Console.WriteLine($"Enter the searching Blood Group");
            Blood blood = Enum.Parse<Blood>(Console.ReadLine(),true);
            
            Console.WriteLine($"Donor's Name | Mobile Number");
            foreach(UserDetails donater in userList){
                if(blood == donater.BloodGroup){
                    Console.WriteLine($"{donater.UserName}\t\t {donater.MobileNumber}"); 
                }   
            }         
        }
    }
}