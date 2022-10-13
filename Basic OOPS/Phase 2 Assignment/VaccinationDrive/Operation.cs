using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public class Operation
    {
        static Beneficiary loginbeneficiary = null;
        public static List<Beneficiary> beneficiaryList = new List<Beneficiary>();
        public static List<Vaccine> vaccineList = new List<Vaccine>();
        public static List<Vaccination> vaccinationList = new List<Vaccination>();

        public static void MainMenu()
        {

            string choice = "Yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice : \n1. Beneficiary Registration\n2. Login\n3. Get Vaccine Info\n4. Exit");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"Beneficiary Registration");
                            Registration();
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
                            Console.WriteLine($"Get Vaccine Info");
                            GetVaccineInfo();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Exit");
                            choice = "No";
                            break;
                        }
                }
            } while (choice == "Yes");
        }
        public static void Registration()
        {

            Console.WriteLine($"Enter Beneficiary Name : ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.WriteLine($"Enter Your Mobile Number : ");
            long mobileNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your City : ");
            string city = Console.ReadLine();

            Beneficiary beneficiary = new Beneficiary(name, gender, mobileNumber, city, age);

            beneficiaryList.Add(beneficiary);

            Console.WriteLine($"Your Customer ID is : {beneficiary.BeneficiaryID}");
        }
        public static void Login()
        {
            string check = "";
            Console.WriteLine($"\nEnter Your Beneficiary ID : ");
            string beneficiaryID = Console.ReadLine();

            foreach (Beneficiary beneficiary in beneficiaryList)
            {
                if (beneficiaryID == beneficiary.BeneficiaryID)
                {
                    check = "Yes";
                    loginbeneficiary = beneficiary;
                    break;
                }
                else
                {
                    check = "No";
                }
            }
            if (check == "Yes")
            {
                Console.WriteLine($"\n Login Successfully");
                SubMenu();
            }
            else
            {
                Console.WriteLine($"Invalid Customer ID");

            }
        }
        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice :\n1. Show My Details\n2. Take Vaccination\n3. My Vaccination History \n4. Next Due Date\n5. Exit");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"Show My Details");
                            ShowMyDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Take Vaccination");
                            TakeVaccination();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"My Vaccination History");
                            VaccinationHistory();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Next Due Date");
                            NextDueDate();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Exit");
                            choice = "no";
                            break;
                        }
                }
            } while (choice == "yes");
        }
        public static void GetVaccineInfo()
        {
            Console.WriteLine($" Vaccine Info");
            Console.WriteLine($"VaccineID   VaccineName  NoOfDoseAvailable");
            foreach (Vaccine vaccine in vaccineList)
            {
                Console.WriteLine($"{vaccine.VaccineID}\t {vaccine.VaccineName}\t {vaccine.NoOfDoseAvailable}");

            }
        }
        public static void ShowMyDetails()
        {
            Console.WriteLine($"Your Details ");
            Console.WriteLine($"BeneficiaryID\tBeneficiaryName\t Gender\t  MobileNumber\t City \tAge");
            foreach (Beneficiary beneficiary in beneficiaryList)
            {
                if (loginbeneficiary.BeneficiaryID == beneficiary.BeneficiaryID)
                {
                    Console.WriteLine($"{beneficiary.BeneficiaryID}\t\t{beneficiary.BeneficiaryName}\t\t {beneficiary.Gender}\t {beneficiary.MobileNumber}\t {beneficiary.City}\t {beneficiary.Age}");
                }
            }
        }
        public static void VaccinationHistory()
        {
            Console.WriteLine($"Your Vaccination History Details ");
            Console.WriteLine($"VaccinationID  RegisterNumber   VaccineID   DoseNumber   VaccinatedDate");
            foreach (Vaccination vaccination in vaccinationList)
            {
                if (loginbeneficiary.BeneficiaryID == vaccination.RegisterNumber)
                {
                    Console.WriteLine($"{vaccination.VaccinationID}\t{vaccination.RegisterNumber}\t{vaccination.VaccineID}\t{vaccination.DoseNumber}\t{vaccination.VaccinatedDate.ToShortDateString()}");
                }
            }
        }
        public static void TakeVaccination()
        {
            //Display the list
            GetVaccineInfo();

            //Get user input
            Console.WriteLine($"Enter the Vaccine ID : ");
            string vaccineId = Console.ReadLine();
            Console.WriteLine($"Enter the Dose Number : ");
            int doseNumber = int.Parse(Console.ReadLine());

            int flag = 0;

            foreach (Vaccination vaccination in vaccinationList)
            {

                if (loginbeneficiary.BeneficiaryID == vaccination.RegisterNumber)
                {

                    if (vaccination.DoseNumber == 3)
                    {
                        Console.WriteLine($"All the three Vaccination course are completed you cannot be vaccinated now");
                        flag = 1;
                        break;
                    }

                    else if (vaccination.DoseNumber <= 2)
                    {
                        DateTime date = DateTime.Now;
                        int count = 0; int increase = 0;

                        while (true)
                        {
                            DateTime AddDate = date.AddDays(count);
                            string check1 = vaccination.VaccinatedDate.ToShortDateString();
                            string check2 = AddDate.ToShortDateString();

                            if (check1 == check2)
                            {
                                break;
                            }
                            count--;
                            increase++;
                        }

                        if (increase >= 30)
                        {
                            DateTime today = DateTime.Now;
                            Vaccination vaccination1 = new Vaccination(loginbeneficiary.BeneficiaryID, vaccineId, doseNumber, DateTime.Now);
                            vaccinationList.Add(vaccination1);

                            foreach (Vaccine vaccine in vaccineList)
                            {
                                if (vaccineId == vaccine.VaccineID)
                                {
                                    vaccine.NoOfDoseAvailable = vaccine.NoOfDoseAvailable - 1;
                                    Console.WriteLine($"Vaccination Succcesfully");
                                    flag = 1;
                                    break;
                                }
                            }
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You have selected different vaccine. You can vaccine with Covaccine / Covishield (His first /second dose vaccine type)");
                    }
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                foreach (Vaccination vaccination in vaccinationList)
                {
                    if (loginbeneficiary.Age > 14)
                    {
                        Vaccination vaccination1 = new Vaccination(loginbeneficiary.BeneficiaryID, vaccineId, doseNumber, DateTime.Now);
                        vaccinationList.Add(vaccination1);
                        foreach (Vaccine vaccine in vaccineList)
                        {
                            if (vaccineId == vaccine.VaccineID)
                            {
                                vaccine.NoOfDoseAvailable = vaccine.NoOfDoseAvailable - 1;
                                Console.WriteLine($"Vaccination Succcesfully");
                                break;
                            }
                        }
                        break;
                    }
                }
            }

        }

        public static void NextDueDate()
        {
            int flag = 0, check = 0;
            foreach (Vaccination vaccination in vaccinationList)
            {
                check++;
                if (loginbeneficiary.BeneficiaryID == vaccination.RegisterNumber)
                {
                    if (vaccination.DoseNumber <= 2)
                    {
                        DateTime date = vaccination.VaccinatedDate.AddDays(30);
                        Console.WriteLine($"Tour next Vaccination Date is : {date.ToShortDateString()}");
                    }
                    else
                    {
                        Console.WriteLine($"“You have completed the vaccination course. Thanks for your participation in the vaccination drive.");
                        break;
                    }
                }
                else
                {
                    flag++;
                }
            }
            if (flag == check)
            {
                Console.WriteLine($"You can take vaccine now");
            }
        }
        public static void AddDefaultData()
        {
            Vaccine vacine1 = new Vaccine(VaccineName.Covishield, 50);
            vaccineList.Add(vacine1);
            Vaccine vacine2 = new Vaccine(VaccineName.Covaccine, 50);
            vaccineList.Add(vacine2);

            Beneficiary beneficiary1 = new Beneficiary("Ravichandran", Gender.Male, 9885858588, "chennai", 21);
            beneficiaryList.Add(beneficiary1);
            Beneficiary beneficiary2 = new Beneficiary("Baskaran", Gender.Male, 9888475757, "chennai", 22);
            beneficiaryList.Add(beneficiary2);

            Vaccination vaccination1 = new Vaccination("BID1001", "CID101", 1, new DateTime(2021, 11, 11));
            vaccinationList.Add(vaccination1);
            Vaccination vaccination2 = new Vaccination("BID1001", "CID101", 2, new DateTime(2022, 03, 11));
            vaccinationList.Add(vaccination2);
            Vaccination vaccination3 = new Vaccination("BID1002", "CID102", 1, new DateTime(2022, 04, 04));
            vaccinationList.Add(vaccination3);
        }


    }
}