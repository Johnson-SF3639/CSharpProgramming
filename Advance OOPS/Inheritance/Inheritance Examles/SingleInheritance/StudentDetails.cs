using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Department{Default, EEE, CSE, MECH, IT};
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentId = 1000;
        public string StudentID { get; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public StudentDetails(string employeId, string name, string fatherName, Gender gender, long phone, Department department, string year): base ( employeId,  name,  fatherName,  gender,  phone){
            s_studentId++;
            StudentID = "SID" + s_studentId;
            Department = department;
            Year = year;
        }

        public void ShowStudent(){
            Console.WriteLine($"Student Id {StudentID}");
            ShowDetails();
            Console.WriteLine($"Department  {Department}\nYear  {Year}");
            
            
        }
        
    }
}