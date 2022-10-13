using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBill
{
    public class Operations
    {
        static EBDetails currentebData = null;
        static List<EBDetails> ebList = new List<EBDetails>();
        public static void MainMenu(){
            
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

        public static void Registretion(){
                Console.WriteLine($"Enter the User Name :");
                string userName = Console.ReadLine();

                Console.WriteLine($"Enter the Phone Number : ");
                long phoneNumber =Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"Enter the Mail ID :");
                string mailID = Console.ReadLine();

                Console.WriteLine($"Enter the Unit :");
                int unit = Convert.ToInt32(Console.ReadLine());

                EBDetails eBDetails = new EBDetails(userName,phoneNumber,mailID,unit);

                ebList.Add(eBDetails);
                
                Console.WriteLine($"Your Register Number : {eBDetails.MeterID}");
        }
        
        public static void Login()
        {
            Console.WriteLine($"Enter Your Register Number");
            string meterId = Console.ReadLine().ToUpper();

            foreach (EBDetails ebData in ebList)
            {
                if (ebData.MeterID == meterId)
                {
                    Console.WriteLine($"Login Successfull");
                    currentebData = ebData;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string pass = "Yes";
            do
            {
                Console.WriteLine($"\nEnter Your Choice :\n1. Show Details\n2. Get No of Unit\n3. Calculate Bill \n4. Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"Show Details");
                            currentebData.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Get No of Unit");
                            currentebData.GetNoUnit();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Calculate Bill");
                            currentebData.CalculateAmount();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Exit Sub Menu");
                            pass = "No";
                            break;
                        }
                }
            } while (pass == "Yes");
        }
    }
}