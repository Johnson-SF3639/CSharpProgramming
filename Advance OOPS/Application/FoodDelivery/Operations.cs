using System;

namespace FoodDelivery
{
    public delegate void EventManager();
    public class Operations
    {
        public static event EventManager eventlink=null;
        
        BookingDetails book = null;
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<ProductDetails> productList = new List<ProductDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<OrderDetails> tempOrderList = new List<OrderDetails>();
        public static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static CustomerDetails loginUser = null;

        public static void Subcribe(){
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(Operations.MainMenu);
            eventlink += new EventManager(Files.WriteToFile);
        }
        public static void startEvent(){
            Subcribe();
            eventlink();
        }
        public static void MainMenu()
        {
            string choice = "Yes";
            do{
                Console.WriteLine($"Select your Option Below\n1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.WriteLine($"Enter your Option");                
                int action = int.Parse(Console.ReadLine());
                switch(action){
                    case 1:{
                        Registration();
                        break;
                    }
                    case 2:{
                        Login();
                        break;
                    }
                    case 3:{
                        choice="No";
                        break;
                    }
                }
            } while (choice == "Yes");
        }

        public static void Registration(){
            Console.Write($"Enter Customer Name : ");
            string name = Console.ReadLine();

            Console.Write($"Enter Customer Father Name : ");
            string fathername = Console.ReadLine();

            Console.Write($"Enter Customer Gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            Console.Write($"Enter Customer Moblie Number : ");
            long mobileNumber = long.Parse(Console.ReadLine());

            Console.Write($"Enter Customer Date of Birth: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            Console.Write($"Enter Customer Email Id : ");
            string mailID = Console.ReadLine();

            Console.Write($"Enter Customer Location : ");
            string location = Console.ReadLine();
            
            Console.Write($"Enter Customer Wallet Balance : ");
            double walletBalance = double.Parse(Console.ReadLine());

            CustomerDetails customer = new CustomerDetails(name,fathername,gender, mobileNumber,dob,mailID,location,walletBalance);
            customerList.Add(customer);

            Console.WriteLine($"Your Customer ID : {customer.CustomerID}");
            
        }
 
        public static void Login(){
            Console.Write($"Enter Your Customer Id : ");
            string customerID = Console.ReadLine();
            int flag =0;
            foreach(CustomerDetails customer in customerList){
                if(customerID == customer.CustomerID){
                    flag =1;
                    Console.WriteLine($"Login Successsfully");
                    loginUser =customer;
                    SubMenu();
                }
            }if(flag ==0){
                Console.WriteLine($"Invalid user ID");
            }
        }

        public static void SubMenu(){
            string choice = "Yes";
            do{
                Console.WriteLine($"Select your Option Below the Sub Menu : \n1.Show Food Item Details\n2. Order Food\n3. Cancel Order\n4. Order History\n5. Recharge Wallet\n6. Exit");
                Console.WriteLine($"Enter your Option");                
                int action = int.Parse(Console.ReadLine());
                switch(action){
                    case 1:{
                        ShowFoodItem();
                        break;
                    }
                    case 2:{
                        OrderFood();
                        break;
                    }
                    case 3:{
                        CancelOrder();
                        break;
                    }
                    case 4:{
                        OrderHistory();
                        break;
                    }
                    case 5:{
                        loginUser.WalletRecharge();
                        break;
                    }
                    case 6:{
                        choice="No";
                        break;
                    }
                }
            } while (choice == "Yes");
        }

        public static void OrderFood(){
            string act = "No";
            do{
            //Show Product details
            ShowFoodItem();

            //get  food id and quantity
            Console.WriteLine($"Enter the Food ID");
            string foodId= Console.ReadLine();
        
            Console.WriteLine($"Enter the Quantity");
            int quantity = int.Parse(Console.ReadLine());

            //check available 
            foreach(ProductDetails product in productList){
                if(foodId == product.FoodID){
                    double amount = product.PricePerQuantity*quantity; 
                    //wallet check balance
                    if(loginUser.WalletBalance >= amount){

                        OrderDetails order = new OrderDetails(book.BookingID,foodId,quantity,amount);
                        tempOrderList.Add(order);
                        loginUser.WalletBalance -=amount;             
                        
                    }else{
                        Console.WriteLine($"Wallet Balance is Low");
                        break;
                    }
                }
            }
            Console.Write($"Do you want to Order more (Yes/No) : ");
            act = Console.ReadLine();

            }while(act != "No"); 
            Console.WriteLine($"Do you want Buy this Products");
            string confirm = Console.ReadLine();
            if(confirm == "Yes"){
                double totalAmount =0;
                foreach(OrderDetails order in tempOrderList){
                    totalAmount += order.PriceOfOrder;;
                }
                book.CustomerID = loginUser.CustomerID;
                book.TotalPrice = totalAmount;
                book.DateOfBooking = DateTime.Now;
                book.BookingStatus = BookingStatus.Booked;                    
                bookingList.Add(book);
                orderList.AddRange(tempOrderList);
            }
                 
        }

        public static void CancelOrder(){
            Console.WriteLine($"BookingID   CustomerID   TotalPrice   DateOfBooking   BookingStatus");
            foreach(BookingDetails booking in bookingList){
                if(loginUser.CustomerID == booking.CustomerID){
                    Console.WriteLine($"{booking.BookingID}   {booking.CustomerID}   {booking.TotalPrice}   {booking.DateOfBooking}   {booking.BookingStatus}");
                }
            }
            Console.WriteLine($"Enter the Booking ID :");
            string bookingId =Console.ReadLine();

            
            foreach(BookingDetails booking in bookingList){
                if(bookingId == booking.BookingID && booking.BookingStatus == BookingStatus.Booked){
                    booking.BookingStatus = BookingStatus.Cancelled;
                    loginUser.WalletBalance += booking.TotalPrice;
                    Console.WriteLine($"Cancelled Successfully");                   
                }
            }
            
            
        }

        public static void OrderHistory(){
            Console.WriteLine($"BookingID   CustomerID   TotalPrice   DateOfBooking   BookingStatus");
            foreach(BookingDetails booking in bookingList){
                if(loginUser.CustomerID == booking.CustomerID){
                    Console.WriteLine($"{booking.BookingID}   {booking.CustomerID}   {booking.TotalPrice}   {booking.DateOfBooking}   {booking.BookingStatus}");
                }
            }
        }

        public static void ShowFoodItem(){
            Console.WriteLine($"FoodID  FoodName   PricePerQuantity");
            foreach(ProductDetails product in productList){
                Console.WriteLine($"{product.FoodID}  {product.FoodName}   {product.PricePerQuantity}");
            }
        }


        public static void Default(){
            OrderDetails order1 = new OrderDetails("BID3001", "FID101", 2, 200);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("BID3001", "FID102", 2, 300);
            orderList.Add(order2);
            OrderDetails order3 = new OrderDetails("BID3001", "FID103", 1, 80);
            orderList.Add(order3);
            OrderDetails order4 = new OrderDetails("BID3002", "FID101", 1, 100);
            orderList.Add(order4);
            OrderDetails order5 = new OrderDetails("BID3002", "FID102", 4, 600);
            orderList.Add(order5);
            OrderDetails order6 = new OrderDetails("BID3002", "FID110", 1, 120);
            orderList.Add(order6);
            OrderDetails order7 = new OrderDetails("BID3002", "FID109", 1, 50);
            orderList.Add(order7);
            OrderDetails order8 = new OrderDetails("BID3003", "FID102", 2, 300);
            orderList.Add(order8);
            OrderDetails order9 = new OrderDetails("BID3003", "FID108", 4, 320);
            orderList.Add(order9);
            OrderDetails order10 = new OrderDetails("BID3003", "FID101", 2, 200);
            orderList.Add(order10);

            BookingDetails book1 = new BookingDetails("CID3001",580,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(book1);
            BookingDetails book2 = new BookingDetails("CID3002",870,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(book2);
            BookingDetails book3 = new BookingDetails("CID3001",820,new DateTime(2022,07,26),BookingStatus.Cancelled);
            bookingList.Add(book3);

            ProductDetails product1 = new ProductDetails("Chicken Briyani", 100);
            productList.Add(product1);
            ProductDetails product2 = new ProductDetails("Mutton Briyani", 150);
            productList.Add(product2);
            ProductDetails product3 = new ProductDetails("Rice", 80);
            productList.Add(product3);
            ProductDetails product4 = new ProductDetails("Noodles", 100);
            productList.Add(product4);
            ProductDetails product5= new ProductDetails("Dosa", 40);
            productList.Add(product5);
            ProductDetails product6 = new ProductDetails("Idly", 20);
            productList.Add(product6);
            ProductDetails product7 = new ProductDetails("Pongal",60);
            productList.Add(product7);
            ProductDetails product8 = new ProductDetails("Vegetable Briyani", 80);
            productList.Add(product8);
            ProductDetails product9= new ProductDetails("Lemon Rice", 50);
            productList.Add(product9);
            ProductDetails product10 = new ProductDetails("Veg Pula", 120);
            productList.Add(product10);

            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, 974774646,new DateTime(1999,11,11), "ravi@gmail.com", "Chennai", 10000);
            customerList.Add(customer1);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, 847575775,new DateTime(1999,11,11), "baskaran@gmail.com", "Chennai", 15000);
            customerList.Add(customer2);
        
        }

    }
}