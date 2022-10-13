using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiInheritance
{
    public class EmployementDetails : StudentDetails
    {
        private static int s_employmentId = 1000;
        public string EmploymentID { get; set; }
        public DateTime Registeration { get; set; }

        public EmployementDetails(string studentId, string employeId, string name, string fatherName, Gender gender, long phone, Department department) : base (studentId, employeId, name, fatherName, gender, phone,  department){
            s_employmentId++;
            EmploymentID = "EID" + s_employmentId;
            Registeration = DateTime.Now;
        }
        public void ShowEmploymentDetails(){
            Console.WriteLine($"/nEmployment ID {EmploymentID}");
            ShowStudent(); 
            Console.WriteLine($"Registeration Date {Registeration.ToShortDateString()}");
            
            
        }
    }
}