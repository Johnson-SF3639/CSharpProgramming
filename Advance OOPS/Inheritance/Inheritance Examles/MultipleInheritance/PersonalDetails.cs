using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance

{
    public enum Gender {Default, Male, Female};
    public class PersonalDetails
    {
        private static int s_employeId = 1000;
        public string EmployeID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender {get; set;}
        public long Phone { get; set; }
    
    public PersonalDetails(string name, string fatherName, Gender gender, long phone){
        s_employeId++;
        EmployeID = "AID"+ s_employeId;
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        Phone = phone;
    }

    
    public PersonalDetails(string employeId, string name, string fatherName, Gender gender, long phone){
        EmployeID = employeId;
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        Phone = phone;
    }

    public void ShowDetails(){
        Console.WriteLine($"\nYour Employee ID : {EmployeID}");
        Console.WriteLine($"Your Name : {Name}");
        Console.WriteLine($"Your Father Name : {FatherName}");
        Console.WriteLine($"Your Gender : {Gender}");
        Console.WriteLine($"Your Phone : {Phone}");
        
    }

    }

}