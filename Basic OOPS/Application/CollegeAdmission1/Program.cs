using System;
using System.Collections.Generic;
namespace CollegeAdmission1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            string check = "Yes";
            List<StudentDetail> studentList = new List<StudentDetail>();

            do
            {                
                StudentDetail student1 = new StudentDetail(); 
                Console.WriteLine($"\nEnter The Preson Details");
                Console.WriteLine($"Enter Your Name");
                student1.Name = Console.ReadLine();

                Console.WriteLine($"Enter Your Father Name");
                student1.FatherName = Console.ReadLine();

                Console.WriteLine($"Enter Your Date of Birth");
                student1.DOB = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

                Console.WriteLine($"Enter Your Gender");
                student1.Gender = Console.ReadLine();

                Console.WriteLine($"Enter Your Phone No");
                student1.Phone = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"Enter Your Email");
                student1.Mail = Console.ReadLine();

                // Console.WriteLine($"Enter Your Physics Mark");
                // student1.Physics = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine($"Enter Your Chemistry Mark");
                // student1.Chemistry = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine($"Enter Your Maths Mark");
                // student1.Maths = Convert.ToInt32(Console.ReadLine());
                
                //Adding
                studentList.Add(student1);

                Console.WriteLine($"Are you willing to Join in this college (Yes/No) : ");
                check = Console.ReadLine().ToLower();
            } while (check == "yes");

            //List Display
            int i = 1;
            foreach (StudentDetail student in studentList)
            {
                Console.WriteLine($"\n{i}st Preson Details : ");
                Console.WriteLine($"Your Name : {student.Name}");
                Console.WriteLine($"Your Father Name : {student.FatherName}");
                Console.WriteLine($"Your Date of Birth : {student.DOB.ToShortDateString()}");
                Console.WriteLine($"Your Gender : {student.Gender}");
                Console.WriteLine($"Your Phone No :  {student.Phone}");
                Console.WriteLine($"Your Email : {student.Mail}");
                Console.WriteLine($"Your Physics Mark : {student.Physics}");
                Console.WriteLine($"Your Chemistry Mark : {student.Chemistry}");
                Console.WriteLine($"Your Maths Mark : {student.Maths}");
                i++;
            }
        }
    }
}