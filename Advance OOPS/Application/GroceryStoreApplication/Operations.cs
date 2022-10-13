using System;
using System.Collections.Generic;
namespace GroceryStoreApplication
{
    public delegate void EventManager();
    class Operations
    {
        public static event EventManager eventlink=null;
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<CustomerDetails> customerList = new List<CustomerDetails>();
        public static List<ProductDetails> productList = new List<ProductDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<OrderDetails> tempOrderList = new List<OrderDetails>();
        public static CustomerDetails currentLoginCustomer;
        public static void MainMenu()
        {
            // DefaultData();
            string choice = "Yes";
            do
            {
                Console.WriteLine($"Main Menu \n1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.WriteLine($"Enter your Option :");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exiting Main Menu");
                            choice = "No";
                            break;
                        }
                }
            } while (choice == "Yes");
        }
        public static void startEvent(){
            Subscribe();
            eventlink();
        }
        public static void Subscribe(){
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(MainMenu);
            eventlink += new EventManager(Files.WriteFile);
        }
        public static void CustomerRegistration()
        {

            Console.WriteLine($"Customer Registration Method Call");

            Console.WriteLine($"Enter your Name :");
            string customerName = Console.ReadLine();

            Console.WriteLine($"Enter your Father Name :");
            string fatherName = Console.ReadLine();

            Console.WriteLine($"Enter your Gender :");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.WriteLine($"Enter your Mobile :");
            long mobile = long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Date of Birth :");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), ("dd/MM/yyyy"), null);

            Console.WriteLine($"Enter your mail ID :");
            string mailId = Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(customerName, fatherName, gender, mobile, dob, mailId);
            customerList.Add(customer);

            Console.WriteLine($"Your Customer is : {customer.CustomerID}");


        }
        public static void CustomerLogin()
        {
            Console.WriteLine($"Enter the Customer ID :");
            string customerID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (customerID == customer.CustomerID)
                {
                    flag = false;
                    currentLoginCustomer = customer;
                    Console.WriteLine($"Login Successfully");
                    SubMenu();
                }
            }
            if (flag)
            {
                Console.WriteLine($"Invail Customer ID ");
            }
        }
        public static void SubMenu()
        {
            bool choice = true;
            do
            {
                Console.WriteLine($"Sub Menu \n1. Show Customer Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. Cancel Order\n7. Exit");
                Console.WriteLine($"Enter your Options");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"{"CustomerID",-10}\t{"Name",-10}{"FatherName",-13}\t{"Gender",-8}\t{"Mobile",-10}\t{"DOB",-10}\t{"MailID",-10}");
                            currentLoginCustomer.ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"ProductID   ProductName   QuantityAvailable   PricePerQuantity");
                            foreach (ProductDetails product in productList)
                            {
                                product.ShowProductDetails();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Wallet Recharge");
                            currentLoginCustomer.WalletRecharge();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Take Order");
                            TakeOrder();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Modify Order Quantity");

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Cancel Order");

                            break;
                        }
                    case 7:
                        {
                            choice = false;
                            Console.WriteLine($"Exit");

                            break;
                        }

                }
            } while (choice);
        }
        public static void TakeOrder()
        {
            /*
            Show Product Details List
            Select a project & Check for Product Quanitity
            Get the Quantity & compare with Availblity
            Calculate Price and compare with Customer wallet
            Take order and create Object
            */
            string choice = "Yes";
            double totalPrice = 0;

            BookingDetails booking = new BookingDetails(currentLoginCustomer.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);

            do
            {
                int amount = 0, flag = 0;
                foreach (ProductDetails product in productList)
                {
                    product.ShowProductDetails();
                }
                Console.WriteLine($"Enter the Product ID");
                string productID = Console.ReadLine().ToUpper();

                foreach (ProductDetails product in productList)
                {
                    if (productID == product.ProductID)
                    {
                        flag = 1;
                        Console.WriteLine($"Enter the Quanitity you want to buy :");
                        int quanitity = int.Parse(Console.ReadLine());
                        if (product.QuantityAvailable > quanitity)
                        {
                            amount = product.PricePerQuantity * quanitity;
                            product.QuantityAvailable -= quanitity;
                            OrderDetails localOrder = new OrderDetails(booking.BookingID, productID, quanitity, amount);
                            tempOrderList.Add(localOrder);
                            Console.WriteLine($"Your Product is Added to the Cart");
                        }
                        else
                        {
                            Console.WriteLine($"Quantity is Low");
                        }
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine($"Invailed ID");
                }
                Console.WriteLine($"Do you want to buy more Product ?(Yes/No)");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

            foreach (OrderDetails order in tempOrderList)
            {
                totalPrice += order.PriceOfOrder;
            }
            Console.WriteLine($"Do you want Proceed : (Yes/no)");
            string wantToProceed = Console.ReadLine().ToLower();

            if (wantToProceed == "yes")
            {
                while (totalPrice > currentLoginCustomer.WalletBalance)
                {
                    Console.WriteLine($"You want to Recharge Imediately\nThe total Price is :{totalPrice} but your balance is :{currentLoginCustomer.WalletBalance}\nYou want {totalPrice - currentLoginCustomer.WalletBalance} amount");
                    currentLoginCustomer.WalletRecharge();
                }
                currentLoginCustomer.WalletBalance -= totalPrice;
                booking.BookingStatus = BookingStatus.Booked;
                booking.TotalPrice = totalPrice;
                orderList.AddRange(tempOrderList);
                bookingList.Add(booking);
                Console.WriteLine($"Your Cart is Deleted");
                
                Console.WriteLine($"Your Order is Successful and Booking ID is : {booking.BookingID}");
                
            }else{
                foreach(OrderDetails order in tempOrderList){
                    foreach(ProductDetails product in productList){
                        product.QuantityAvailable+= order.PurchaseCount ;
                    }
                }
            }
        }

        // public static void CancelBooking(){
        //     Console.WriteLine($"Enter the Cancel Order ID : ");
        //     string cancelID = Console.ReadLine();
        //     foreach(OrderDetails order in orderList){
        //         if(order.OrderID == cancelID){
        //         }
        //     }  
        // }

        public static void DefaultData()
        {
            //Customer Details Data
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, 974774646, new DateTime(2000, 12, 12), "ravi@gmail.com");
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com");
            //Add List 
            customerList.Add(customer1);
            customerList.Add(customer2);


            //Booking Details Data
            BookingDetails booking1 = new BookingDetails("CID3001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID3002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID3001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails("CID3002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);
            //Add List 
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);




            //Order Details Data
            OrderDetails order1 = new OrderDetails("BID3001", "PID101", 2, 80);
            OrderDetails order2 = new OrderDetails("BID3001", "PID102", 2, 100);
            OrderDetails order3 = new OrderDetails("BID3001", "PID103", 1, 40);
            OrderDetails order4 = new OrderDetails("BID3002", "PID101", 1, 40);
            OrderDetails order5 = new OrderDetails("BID3002", "PID102", 4, 200);
            OrderDetails order6 = new OrderDetails("BID3002", "PID110", 1, 140);
            OrderDetails order7 = new OrderDetails("BID3002", "PID109", 1, 20);
            OrderDetails order9 = new OrderDetails("BID3001", "PID102", 2, 100);
            OrderDetails order8 = new OrderDetails("BID3001", "PID108", 4, 100);
            OrderDetails order10 = new OrderDetails("BID3001", "PID101", 2, 80);
            //Add List 
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
            orderList.Add(order7);
            orderList.Add(order8);
            orderList.Add(order9);
            orderList.Add(order10);

            //Product Details Data
            ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
            ProductDetails product2 = new ProductDetails("Rice", 100, 50);
            ProductDetails product3 = new ProductDetails("Milk", 10, 40);
            ProductDetails product4 = new ProductDetails("Coffee", 10, 10);
            ProductDetails product5 = new ProductDetails("Tea", 10, 10);
            ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
            ProductDetails product7 = new ProductDetails("Salt", 10, 10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder ", 10, 25);
            ProductDetails product9 = new ProductDetails("Chilli Powder", 10, 20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);
            //Add List 
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);
        }
    }
}