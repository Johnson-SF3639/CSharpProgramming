using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum Gender {Default, Male, Female, Transgender};
    public class Beneficiary
    {
        private static int s_beneficiary =1000;
        
        public string BeneficiaryID { get; }
        public string BeneficiaryName {get; set;}
        public int Age {get; set;}
        public Gender Gender {get; set;}
        public long MobileNumber { get; set; } 
        public string City { get; set; }  
    
        public Beneficiary(string name,  Gender gender, long mobileNumber, string city, int age){
            s_beneficiary++;
            BeneficiaryID ="BID"+s_beneficiary;
            BeneficiaryName = name;
            Age = age;
            Gender = gender;
            MobileNumber = mobileNumber;
            City = city;
        }
        
        public Beneficiary(string data){
            string[] value = data.Split(',');
            s_beneficiary = int.Parse(value[0].Remove(0,3));
            BeneficiaryID =value[0];
            BeneficiaryName = value[1];
            Age = int.Parse(value[2]);
            Gender =Enum.Parse<Gender>(value[3]);
            MobileNumber = long.Parse(value[4]);
            City = value[5];
        }
        
    }
}