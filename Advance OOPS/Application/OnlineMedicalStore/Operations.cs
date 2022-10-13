using System;

namespace OnlineMedicalStore
{
    public class Operations
    {
        static RegisterationDetails loginUser = null;
        public static List<RegisterationDetails> userList = new List<RegisterationDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        public static void MainMenu(){
            string choice ="Yes";
            do{
                Console.WriteLine($"Welcome to Our Online Store");
                Console.WriteLine($"\nThe Options are :\n1. User Registration\n2. User Login\n3. OrderHistory\n4. Exit");
                Console.Write($"\nEnter your Option : ");
                
                int action = int.Parse(Console.ReadLine());

                switch(action){
                    case 1 :{
                        UserRegisteration();
                        break;
                    }
                    case 2 :{
                        Login();
                        break;
                    }
                    case 3 :{
                        break;
                    }
                    case 4 :{
                        Console.WriteLine($"Exit Successfully");
                        choice = "No";
                        break;
                    }
                }
            }while(choice == "Yes");
        }

        public static void UserRegisteration(){
            Console.WriteLine($"\nEnter Your User Name");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Enter Your User Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your User City");
            string city = Console.ReadLine();

            Console.WriteLine($"Enter Your User Phone Number");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your User Balance");
            double balance = double.Parse(Console.ReadLine());

            RegisterationDetails register = new RegisterationDetails(name,age,city,phoneNumber,balance);

            userList.Add(register);

            Console.WriteLine($"Your User ID is : {register.UserId}");            
        }

        public static void Login(){
            int flag = 0;
            Console.Write($"\nEnter the User ID : ");
            string userID= Console.ReadLine();

            foreach (RegisterationDetails register in userList)
            {
                if(userID == register.UserId){
                    flag = 1;
                    Console.WriteLine($"/nLogin Successfully");
                    loginUser = register;
                    SubMenu();  
                }
            }
            if(flag == 1){
                Console.WriteLine($"Invalid User");   
            }
        }

        public static void SubMenu(){
            string choice ="Yes";
            do{
                Console.WriteLine($"\nThe User Options are :\n1. Show Medicine List\n2. Purchase Medicine\n3. Cancel Purchase\n4. Show purchase history\n5. Recharge\n6. Exit");
                Console.Write($"\nEnter your Option : ");
                
                int action = int.Parse(Console.ReadLine());

                switch(action){
                    case 1 :{
                        ShowMedicine();
                        break;
                    }
                    case 2 :{
                        Purchase();
                        break;
                    }
                    case 3 :{
                        CancelPurchase();
                        break;
                    }
                    case 4 :{
                        PurchaseHistory();
                        break;
                    }
                    case 5 :{
                        Recharge();
                        break;
                    }
                    case 6 :{
                        Console.WriteLine($"Exit User Menu Successfully");
                        choice = "No";
                        break;
                    }
                }
            }while(choice == "Yes");
        }

        public static void ShowMedicine(){
            Console.WriteLine($"MedicineID   Medicine Name   Available   Price   DateOfExpiry ");
            foreach(MedicineDetails medicine in medicineList){
                Console.WriteLine($"{medicine.MedicineID}\t   {medicine.MedicineName}\t{medicine.AvailableCount}\t{medicine.Price} \t{medicine.DateOfExpiry.ToShortDateString()}");
                
            }
        }

        public static void Purchase(){
            //show List
            ShowMedicine();

            //ask details
            Console.Write($"\nEnter the Medicine ID : ");
            string medicineID =Console.ReadLine();
            Console.Write($"Enter the Number of count : ");
            int count = int.Parse(Console.ReadLine());

            //check id and count and balance
            foreach(MedicineDetails medicine in medicineList){
                if(medicineID == medicine.MedicineID && count <= medicine.AvailableCount){
                    if(loginUser.Balance >= ((medicine.Price)*count)){
                        int value = medicine.DateOfExpiry.CompareTo(DateTime.Now);
                        if(value < 1){
                            Console.WriteLine($"Medicine was expired");
                            break;
                        }else{
                            //reduce balance and count
                            medicine.AvailableCount-=count;
                            loginUser.Balance-=(medicine.Price*count);
                            
                            //add list 
                            OrderDetails order = new OrderDetails(loginUser.UserId, medicineID, count, (medicine.Price*count), DateTime.Now,Status.Purchased);
                            orderList.Add(order);

                            //show msg
                            Console.WriteLine($"Medicine was purchased successfully");
                        }
                    }
                }
            }
        }

        public static void CancelPurchase(){
            
            Console.WriteLine($"\nOrderID   UserID   MedicineID   MedicineCount   TotalPrice   OrderDate   OrderStatus");
            foreach(OrderDetails order in orderList){
                if(loginUser.UserId == order.UserID && order.OrderStatus == Status.Purchased){
                    Console.WriteLine($"{order.OrderID}   {order.UserID}   {order.MedicineID}\t   {order.MedicineCount} \t\t  {order.TotalPrice}   {order.OrderDate.ToShortDateString()}   {order.OrderStatus}");
                }
            }
            Console.WriteLine($"\nEnter the Order ID : ");
            string orderId =Console.ReadLine();
            
            foreach(OrderDetails order in orderList){
                if(loginUser.UserId == order.UserID){
                    if(orderId == order.OrderID && order.OrderStatus == Status.Purchased){
                        foreach(MedicineDetails medicine in medicineList){
                            if(medicine.MedicineID == order.MedicineID){
                                medicine.AvailableCount+=order.MedicineCount;
                                loginUser.Balance+=order.TotalPrice;
                                order.OrderStatus = Status.Cancelled;
                                Console.WriteLine($"{order.OrderID} was cancelled successfully");
                            }
                        }
                    }                        
                }
            }
            

        }

        public static void PurchaseHistory(){
            Console.WriteLine($"\nYour Purchase Details");
            Console.WriteLine($"OrderID   UserID   MedicineID   MedicineCount   TotalPrice   OrderDate   OrderStatus");
            foreach(OrderDetails order in orderList){
                if(loginUser.UserId == order.UserID){
                    Console.WriteLine($"{order.OrderID}   {order.UserID}   {order.MedicineID}\t   {order.MedicineCount} \t\t \t {order.TotalPrice}   {order.OrderDate.ToShortDateString()}   {order.OrderStatus}");
                }
            }
        }
        public static void Recharge(){
            Console.Write($"\nEnter your Amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            loginUser.Balance += amount;
            Console.WriteLine($"Your Balance is : {loginUser.Balance}");
        }
        public static void DefaultData(){

            RegisterationDetails registertion1 = new RegisterationDetails("Ravi",33,"Theni",9877774440,400);
            userList.Add(registertion1);
            RegisterationDetails registertion2 = new RegisterationDetails("Baskaran",33,"Chennai",8847757470,500);
            userList.Add(registertion2);

            MedicineDetails data1 = new MedicineDetails("Paracitamol  ",40,5,new DateTime(2022,06,30));
            medicineList.Add(data1);
            MedicineDetails data2 = new MedicineDetails("Calpol       ",10,5,new DateTime(2022,05,30));
            medicineList.Add(data2);
            MedicineDetails data3 = new MedicineDetails("Gelucil      ",3,40,new DateTime(2022,04,30));
            medicineList.Add(data3);
            MedicineDetails data4 = new MedicineDetails("Metrogel     ",5,50,new DateTime(2022,10,30));
            medicineList.Add(data4);
            MedicineDetails data5 = new MedicineDetails("Povidin Iodin",10,50,new DateTime(2022,10,30));
            medicineList.Add(data5);

            OrderDetails order1 = new OrderDetails("UID1001","MD101",3,15,new DateTime (2022,05,13),Status.Purchased);
            orderList.Add(order1);  
            OrderDetails order2 = new OrderDetails("UID1002","MD102",2,10,new DateTime (2022,05,13),Status.Cancelled);
            orderList.Add(order2);  
            OrderDetails order3 = new OrderDetails("UID1003","MD104",2,100,new DateTime (2022,05,13),Status.Purchased);
            orderList.Add(order3);  
            OrderDetails order4 = new OrderDetails("UID1004","MD103",3,120,new DateTime (2022,05,15),Status.Cancelled);
            orderList.Add(order4);  
            OrderDetails order5 = new OrderDetails("UID1005","MD105",5,250,new DateTime (2022,05,15),Status.Purchased);
            orderList.Add(order5);  
            OrderDetails order6 = new OrderDetails("UID1006","MD102",3,15,new DateTime (2022,05,15),Status.Purchased);
            orderList.Add(order6);  


        }

    }
}