using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiInheritance

{
    public enum Department{Default, EEE, CSE, MECH, IT};
    public class StudentDetails : PersonalDetails, IMarkDetails
    {
        private static int s_studentId = 1000;
        public string StudentID { get; }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Maths { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Total { get; set;}
        public double Average { get; set;}

        public StudentDetails(string employeId, string name, string fatherName, Gender gender, long phone, Department department, string year): base ( employeId,  name,  fatherName,  gender,  phone){
            s_studentId++;
            StudentID = "SID" + s_studentId;
            Department = department;
            Year = year;
        }
        
        public StudentDetails(string studentId, string employeId, string name, string fatherName, Gender gender, long phone, Department department): base ( employeId,  name,  fatherName,  gender,  phone){
            StudentID = studentId;
            Department = department;
        }

        public  void GetMark(int maths, int physics, int chemistry ){
            Maths = maths;
            Physics = physics;
            Chemistry = chemistry;
        }
        public  void Calculate(){
            Total =(Maths + Physics + Chemistry);
            Average =  (double)Total / 3 ;
            Console.WriteLine($"\nAverage is : {Average}");
            
        }
        public  void ShowMark(){
            Console.WriteLine($"\nMaths : {Maths}\nPhysics : {Physics}\nChemistry {Chemistry}\n");            
        }

        public void ShowStudent(){
            Console.WriteLine($"\nStudent Id : {StudentID}");
            ShowDetails();
            Console.WriteLine($"Department : {Department}\nYear : {Year}"); 
        }
        
    }
}