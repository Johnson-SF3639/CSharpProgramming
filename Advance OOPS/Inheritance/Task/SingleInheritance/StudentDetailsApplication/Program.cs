using System;
namespace StudentsDetailsApplication{
    class Program{
        public static void Main(string[] args)
        {
            StudentInfo student = new StudentInfo("John","Rajan",9445431834,"john@gmail.com", DateTime.Now, Gender.Male,"1st year","IT",2022);
            Console.WriteLine($"\nRegisterNo\tName\tStandard\tBranch\tAcadamicYear\tFatherName\tPhone\t\tMail\t\tDOB\t\tGender"); 
            student.ShowInfo();
            Console.Write($"\nDo you want to Update your Infomation (Yes/No) : ");
            string action = Console.ReadLine().ToLower();
            if(action == "yes"){          
                student.UpdateInfo();
                Console.WriteLine($"Your Update Info : \nRegisterNo\tName\tStandard\tBranch\tAcadamicYear\tFatherName\tPhone\t\tMail\t\tDOB\t\tGender"); 
                student.ShowInfo();
            }else{
                Console.WriteLine($"\nYou're Welcome");
            } 
            Console.WriteLine($"\n");
            
        }
    }
}