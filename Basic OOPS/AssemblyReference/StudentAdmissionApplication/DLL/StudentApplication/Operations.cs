using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication
{
    public class Operations
    {
        public static void MainMenu()
        {            
            string check = "Yes";
            //File
            List<StudentDetails> studentList = new List<StudentDetails>();

            do
            {

                Console.WriteLine($"\nEnter The Preson Details : ");
                Console.WriteLine($"Enter Your Name");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter Your Father Name");
                string fatherName = Console.ReadLine();

                Console.WriteLine($"Enter Your Date of Birth");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

                Console.WriteLine($"Enter Your Gender");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

                Console.WriteLine($"Enter Your Phone No");
                long phone = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"Enter Your Email");
                string mail = Console.ReadLine();

                Console.WriteLine($"Enter Your Physics Mark");
                int physics = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter Your Chemistry Mark");
                int chemistry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter Your Maths Mark");
                int maths = Convert.ToInt32(Console.ReadLine());
            
                StudentDetails student1 = new StudentDetails(name,fatherName,dob,gender,phone,mail,physics,chemistry,maths);
                // StudentDetails student1 = new StudentDetails();  
                
                //Adding
                studentList.Add(student1);

                Console.WriteLine($"Are you willing to Join in this college (Yes/No) : ");
                check = Console.ReadLine().ToLower();
            } while (check == "yes");

            //List Display
            int i = 1;
            foreach (StudentDetails student in studentList)
            {
                Console.WriteLine($"\n{i}st Preson Details : ");
                Console.WriteLine($"Your Register Number : {student.RegisterNumber}");
                Console.WriteLine($"Your Name : {student.Name}");
                Console.WriteLine($"Your Father Name : {student.FatherName}");
                Console.WriteLine($"Your Date of Birth : {student.DOB.ToShortDateString()}");
                Console.WriteLine($"Your Gender : {student.Gender}");
                Console.WriteLine($"Your Phone No :  {student.Phone}");
                Console.WriteLine($"Your Email : {student.Mail}");
                Console.WriteLine($"Your Physics Mark : {student.Physics}");
                Console.WriteLine($"Your Chemistry Mark : {student.Chemistry}");
                Console.WriteLine($"Your Maths Mark : {student.Maths}");
                bool eligible = student.CheckEligiblity(75.0);
                if(eligible){
                    Console.WriteLine($"You are Eligible for Addmission");
                }else{
                    Console.WriteLine($"You are not Eligible for Addmission");
                }
                i++;
            }
        }
    }
}