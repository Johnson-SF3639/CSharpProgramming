using System;

namespace AdmissionLibrary
{
    public enum Gender {Default, Male, Female, Transgender}
    public class StudentDetails
    {
        //Fields
        // private string _name="John";
        private static int s_registerNumber=3000;

        //Property
        // public string Name { get{return _name;} set{_name = value;} }

        //Auto Property
        public string RegisterNumber {get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics{ get; set; }
        public int Chemistry{ get; set; }
        public int Maths{ get; set; }

        // Parameter Constructor
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, long phone,string mail, int physics, int chemistry, int maths){
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        //method
        public bool CheckEligiblity(double cutOff){
            double average = (double) (Physics+Chemistry+Maths)/3.0;
            if(average >= cutOff){
                return true;
            }else{
                return false;
            }
        }
    }
}