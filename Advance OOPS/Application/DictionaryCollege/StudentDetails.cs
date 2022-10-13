using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public enum Gender {Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentId = 3000;
        public string StudentId { get; }
        public string StudentName {get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender {get; set;}
        public int Physics {get; set;}
        public int Chemistry {get; set;}
        public int Maths {get; set;}

        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, int physics, int chemistry, int maths){
            s_studentId++;
            StudentId = "SF"+ s_studentId;
            StudentName = name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void ShowDetails(){
            Console.WriteLine($"\nStudent Id : {StudentId}");
            Console.WriteLine($"Student Name : {StudentName}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Student Date of Birth : {DOB.ToShortDateString()}");
            Console.WriteLine($"Student Gender : {Gender}");
            Console.WriteLine($"Physics Mark : {Physics}");
            Console.WriteLine($"Chemistry Mark : {Chemistry}");
            Console.WriteLine($"Maths Mark : {Maths}");
        }
        public bool CheckEligiblity(double cutOff){
            double average = (double)(Physics+Chemistry+Maths)/3.0;
            if(average >= cutOff){
                return true;
            }
            else{
                return false;
            }        
        }

        public void DisplayDetails(){

        }

    }
}