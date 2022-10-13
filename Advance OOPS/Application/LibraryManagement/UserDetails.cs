using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Department {Default, EEE, ECE, CSE}
    public enum Gender {Default, Male, Female, Transgender}
    public class UserDetails
    {
        private static int s_registerNumber = 3000;
        public string RegisterId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long Moblie { get; set; }
        public string MailID { get; set; }

        public UserDetails(string name, Gender gender, Department department, long mobile, string mailId){
            s_registerNumber++;
            RegisterId ="SF" + s_registerNumber;
            Name = name;
            Gender = gender;
            Department =department;
            Moblie = mobile;
            MailID = mailId;
        }

    }
}