using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsDetailsApplication
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNo = 1000;
        public string RegisterNo { get; set; }
        public string  Standard { get; set; }
        public string  Branch { get; set; }
        public int  AcadamicYear { get; set; }

        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, string standard, string branch, int acadamicYear) : base( name,  fatherName, phone,  mail, dob, gender){
            s_registerNo++;
            RegisterNo = "RIG"+s_registerNo;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
        public void UpdateInfo(){
            Console.WriteLine($"Enter the Phone Number : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the Mail ID");
            string mail = Console.ReadLine();     
            Name = name;
            Mail = mail; 
        }
        public void ShowInfo(){
            Console.WriteLine($"{RegisterNo}\t\t{Name}\t{Standard}\t{Branch}\t{AcadamicYear}\t\t{FatherName}\t\t{Phone}\t{Mail}\t{DOB.ToShortDateString()}\t{Gender}");         
        }
        
    }
}