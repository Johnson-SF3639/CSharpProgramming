using System;

namespace CollegeAdmission
{
    public static class Operation
    {
        static StudentDetails currentStudent = null;
        
        public static Lists<AdmissionDetails> admissionList = new Lists<AdmissionDetails>();
        public static Lists<StudentDetails> studentList = new Lists<StudentDetails>();
        public static Lists<DepartmentDetails> departmentList = new Lists<DepartmentDetails>();
        public static void MainMenu()
        {
            string choice = "Yes";
            do
            {
                Console.WriteLine($"\nSelect Your Option To Action \n1. Registretion\n2. Login\n3. Exit\n");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine($"Registretion");
                            Registretion();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exit");
                            choice = "No";
                            break;
                        }
                }
            } while (choice == "Yes");
        }

        public static void Registretion()
        {

            Console.WriteLine($"\nEnter The Preson Details : ");
            Console.WriteLine($"Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Your Father Name");
            string fatherName = Console.ReadLine();

            Console.WriteLine($"Enter Your Date of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

            Console.WriteLine($"Enter Your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

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

            StudentDetails student1 = new StudentDetails(name, fatherName, dob, gender, phone, mail, physics, chemistry, maths);

            studentList.Add(student1);

            Console.WriteLine($"Your Register Number : {student1.RegisterNumber}");
        }
        public static void Login()
        {
            Console.WriteLine($"Enter Your Register Number");
            string registerNumber = Console.ReadLine().ToUpper();

            foreach (StudentDetails student in studentList)
            {
                if (student.RegisterNumber == registerNumber)
                {
                    Console.WriteLine($"Login Successfull");
                    currentStudent = student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string pass = "Yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice :\n1. Show Details\n2. Check Eligiblity\n3. Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"1. Show Details");
                            currentStudent.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"2. Check Eligiblity");
                            bool eligible = currentStudent.CheckEligiblity(75.0);
                            if (eligible)
                            {
                                Console.WriteLine($"You are Eligible for Addmission");
                            }
                            else
                            {
                                Console.WriteLine($"You are not Eligible for Addmission");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exit Sub Menu");
                            pass = "No";
                            break;
                        }
                }
            } while (pass == "Yes");
        }

        // public static void DefaultData(){
            // DepartmentDetails department = new DepartmentDetails("CSE",10);
            // departmentList.Add(department);
            // DepartmentDetails department1 = new DepartmentDetails("EEE",10);
            // departmentList.Add(department1);
            // DepartmentDetails department2 = new DepartmentDetails("MECH",10);
            // departmentList.Add(department2);
            // DepartmentDetails department3 = new DepartmentDetails("IT",10);
            // departmentList.Add(department3);

            
            // AdmissionDetails admission1 = new AdmissionDetails("SID101", "DID101",Status.Applied);
            // admissionList.Add(admission1);
            // AdmissionDetails admission2 = new AdmissionDetails("SID102", "DID101",Status.Applied);
            // admissionList.Add(admission2);
            // AdmissionDetails admission3 = new AdmissionDetails("SID103", "DID101",Status.Applied);
            // admissionList.Add(admission3);
        // }

    }
}