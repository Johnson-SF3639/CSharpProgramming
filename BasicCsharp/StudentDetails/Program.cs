using System;
namespace StudentDetails{
    class Program{
        public static void Main(string[] args)
        {
            string studentName,studentFatherName, emailId;
            char studentGender;
            int studentAge;
            float chemistryMark, physicsMark, mathMark, sum;
            long phoneNumber;
            double avarage, precentage;
            Console.WriteLine("Student Details");
            Console.WriteLine("Enter Student Name :");
            studentName= Console.ReadLine();

            Console.WriteLine("Enter Student Father Name :");
            studentFatherName= Console.ReadLine();

            Console.WriteLine("Enter Student Email ID :");
            emailId= Console.ReadLine();

            Console.WriteLine("Enter Student Phone Number :");
            phoneNumber= Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Student Age :");
            studentAge=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Genter :");
            studentGender= Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Mark :");
            chemistryMark= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Physics Mark :");
            physicsMark= float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths Mark :");
            mathMark= float.Parse(Console.ReadLine());
            
            sum=(mathMark + chemistryMark + physicsMark);
            avarage= (double)sum/3;

            precentage = ((double)sum/600)*100;
   
            Console.WriteLine("The Student Name is :" +studentName);
            Console.WriteLine($"The Student Father Name is : {studentFatherName}");
            Console.WriteLine("The Student Email Id is : {0} ",emailId);
            Console.WriteLine("The Student Phone Number is :" +phoneNumber);
            Console.WriteLine("The Student Age is : " +studentAge);
            Console.WriteLine("The Student Genter is : " +studentGender);
            Console.WriteLine("Total is :" +sum);
            Console.WriteLine("Avarage is : " +avarage);
            Console.WriteLine("Precentage is :" +precentage);
        }
    }
}
