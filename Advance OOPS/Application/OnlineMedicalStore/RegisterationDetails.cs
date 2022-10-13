using System;

namespace OnlineMedicalStore
{
    public class RegisterationDetails
    {
        private static int s_userId = 1000;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }

        public RegisterationDetails(string name, int age, string city, long phoneNumber, Double balance){
            s_userId++;
            UserId = "UID" + s_userId;
            UserName = name;
            Age =age;
            City = city;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }
        public RegisterationDetails(string data){
            string[] value = data.Split(',');
            s_userId =int.Parse( value[0].Remove(0,3));
            UserId = value[0];
            UserName = value[1];
            Age =int.Parse(value[2]);
            City = value[3];
            PhoneNumber = long.Parse(value[4]);
            Balance = double.Parse(value[5]);
        }
    }
}