using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class Operations
    {
        static KeyValue<int,StudentDetails> dictionary = new KeyValue<int, StudentDetails>();
        static StudentDetails uniqueStudent = null;
        static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();
        static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        // static List<StudentDetails> studentsList = new List<StudentDetails>();
        public static void MainMenu()
        {
            string choice = "yes";

            AdmissionDetails admission = new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 05, 11, 00, 00, 00), Status.Booked);
            admissionList.Add(admission);

            AdmissionDetails admission1 = new AdmissionDetails("SF3002", "DID101", new DateTime(2022, 05, 11, 00, 00, 00), Status.Booked);
            admissionList.Add(admission1);

            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            departmentList.Add(department1);

            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            departmentList.Add(department2);

            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            departmentList.Add(department3);

            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            departmentList.Add(department4);

            StudentDetails student1 = new StudentDetails("Baskaran", "Sethurajan", new DateTime(1999, 11, 11, 00, 00, 00), Gender.Male, 95, 95, 95);
            dictionary.Add(1,student1);

            StudentDetails student2 = new StudentDetails("Ravi", "Ettapparajan", new DateTime(1999, 11, 11, 00, 00, 00), Gender.Male, 95, 95, 95);
            dictionary.Add(2,student2);

            do
            {
                Console.WriteLine("\nEnter your choice from :\n1. Student Registration\n2. Student Login\n3. Check Department & Seat Availablity\n4. Exit");
                
                foreach(KeyValue<int,StudentDetails> i in dictionary){
                   Console.WriteLine($"Key : {i.Key} Value :");
                 i.Value.ShowDetails();
                }

                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"Registration Process");
                            Console.WriteLine($"");
                            
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Login Process");
                            // Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Department Check Process");
                            Console.WriteLine($"\nDepartmentId  |  DepartmentName  |  NumberOfSeats");
                            foreach (DepartmentDetails department in departmentList)
                            {
                                Console.WriteLine($"{department.DepartmentId}\t\t  {department.DepartmentName}\t\t\t   {department.NumberOfSeats}");
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Thankyou for Coming");
                            choice = "No";
                            break;
                        }
                }

            } while (choice == "yes");
        }
        public static void Registration()
        {

            Console.WriteLine($"Enter Student Name : ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Father Name : ");
            string fatherName = Console.ReadLine();

            Console.WriteLine($"Enter Your Date of Birth :");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

            Console.WriteLine($"Enter Your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.WriteLine($"Enter Your Physics Mark");
            int physics = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Chemistry Mark");
            int chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Maths Mark");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student = new StudentDetails(name, fatherName, dob, gender, physics, chemistry, maths);

            // studentsList.Add(student);

            Console.WriteLine($"Your Register Number {student.StudentId}");
        }
        // public static void Login()
        // {
        //     Console.WriteLine($"Enter your Student ID");
        //     string studentId = Console.ReadLine();

        //     foreach (StudentDetails student in studentsList)
        //     {
        //         if (student.StudentId == studentId)
        //         {
        //             Console.WriteLine($"Login Successfully\n");
        //             uniqueStudent = student;
        //             SubMenu();
        //         }
        //     }
        // }
        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                Console.WriteLine($"\nEnter your Choices :\n1. Check Eligiblity\n2. Show Details\n3. Take Admission\n4. Cancel Admission\n5. Show Admission Details\n6. Exit ");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            bool eligible = uniqueStudent.CheckEligiblity(75.0);
                            if (eligible)
                            {
                                Console.WriteLine($"You are Eligible for Admission");
                            }
                            else
                            {
                                Console.WriteLine($"You are Not Eligible for Admission");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Show your Details");
                            uniqueStudent.ShowDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Admission Take Process");
                            Console.WriteLine($"Department Name   Number of Seats");
                            foreach (DepartmentDetails department in departmentList)
                            {
                                Console.WriteLine($"\t{department.DepartmentName} \t\t {department.NumberOfSeats}");
                            }
                            Console.WriteLine($"Select One Department : ");
                            string selectDepartment = Console.ReadLine();

                            int check = 0;
                            foreach (DepartmentDetails department in departmentList)
                            {
                                if (selectDepartment == department.DepartmentName)
                                {
                                    if (department.NumberOfSeats > 0)
                                    {
                                        bool eligibleCheck = uniqueStudent.CheckEligiblity(75.0);
                                        if (eligibleCheck)
                                        {
                                            foreach (AdmissionDetails admission in admissionList)
                                            {
                                                if (uniqueStudent.StudentId == admission.StudentId && ((admission.AdmissionStatus == Status.Booked) || (admission.AdmissionStatus == Status.Admitted)))
                                                {
                                                    check = 1;
                                                    break;
                                                }
                                            }
                                            if (check == 1)
                                            {
                                                Console.WriteLine($"You are Already Applied or not eligible");
                                            }
                                            else
                                            {
                                                department.NumberOfSeats -= 1;
                                                AdmissionDetails admission1 = new AdmissionDetails(uniqueStudent.StudentId, department.DepartmentId, DateTime.Now, Status.Admitted);
                                                admissionList.Add(admission1);
                                                Console.WriteLine($"Admission took successfully. Your admission ID - {admission1.AdmissionId}");
                                                break;
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Admission Cancel Process");
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (uniqueStudent.StudentId == admission.StudentId)
                                {
                                    Console.WriteLine($"AdmissionId  StudentId  DepartmentId  AdmissionDate  AdmissionStatus");
                                    Console.WriteLine($"{admission.AdmissionId}\t\t {admission.StudentId}\t\t {admission.DepartmentId}\t\t {admission.AdmissionDate.ToShortDateString()}\t\t {admission.AdmissionStatus}");
                                    if (admission.AdmissionStatus == Status.Booked || admission.AdmissionStatus == Status.Admitted)
                                    {
                                        Console.WriteLine($"Do you want to cancel your Admission (yes/no): ");
                                        string cancel = Console.ReadLine().ToLower();
                                        if (cancel == "yes")
                                        {
                                            admission.AdmissionStatus = Status.Cancelled;
                                            foreach (DepartmentDetails department in departmentList)
                                            {
                                                if (admission.DepartmentId == department.DepartmentId)
                                                {
                                                    department.NumberOfSeats += 1;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }

                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Admission Details");
                            Console.WriteLine($"AdmissionId  StudentId  DepartmentId  AdmissionDate  AdmissionStatus");
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (uniqueStudent.StudentId == admission.StudentId)
                                {
                                    Console.WriteLine($"{admission.AdmissionId}\t\t {admission.StudentId}\t\t {admission.DepartmentId}\t\t {admission.AdmissionDate.ToShortDateString()}\t {admission.AdmissionStatus}");
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Exit");
                            choice = "no";
                            break;
                        }
                }

            } while (choice == "yes");
        }
    }
}