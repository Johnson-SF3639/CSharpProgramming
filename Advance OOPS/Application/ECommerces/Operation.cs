using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace ECommerces
{
    public delegate void EventManager();
    public class Operation
    {
        private static string _eventNumber;
        public static event EventManager eventlink=null;
        static int i;
        static CustomerDetails loginCustomer = null;
        public static List<CustomerDetails> customersList = new List<CustomerDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<ProductDetails> productList = new List<ProductDetails>();

        public static void Subcribe(){
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(Operation.MainMenu);
            eventlink += new EventManager(Files.WriteFile);
        }
        public static void StartEvent(){
            Subcribe();
            eventlink();
        }
        public static void MainMenu(){

            string choice = "Yes";
            do{
                Console.WriteLine($"\nEnter Your Choice : \n1. Customer Registration\n2. Login and Purchase\n3. Exit");
                int action = int.Parse(Console.ReadLine());

                switch(action){
                    case 1:{
                        Console.WriteLine($"Customer Registration");
                        Registration();
                        break;
                    }
                    case 2:{
                        Console.WriteLine($"Login and Purchase");
                        Login();
                        break;
                    }
                    case 3:{
                        Console.WriteLine($"Exit");
                        choice="No";
                        break;
                    }
                }                
            }while(choice == "Yes");
        }

        public static void Registration(){

            Console.WriteLine($"Enter Customer Name : ");
            string customerName = Console.ReadLine();
            
            Console.WriteLine($"Enter Your City : ");
            string city = Console.ReadLine();
            
            Console.WriteLine($"Enter Your Mobile Number : ");
            long mobileNumber = long.Parse(Console.ReadLine());
            
            Console.WriteLine($"Enter Your Wallet Amount : ");
            double walletBalance = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Enter Your Email ID : ");
            string emailId = Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(customerName,city,mobileNumber,walletBalance,emailId);

            customersList.Add(customer);

            Console.WriteLine($"Your Customer ID is : {customer.CustomerId}");                      
        }
        
        public static void Login(){
            string check = "";
            Console.WriteLine($"\nEnter Your Customer ID : ");
            string customerId = Console.ReadLine();

            foreach(CustomerDetails customer in customersList){
                if(customerId == customer.CustomerId){
                    check = "Yes";  
                    loginCustomer = customer; 
                    break;                                  
                }else{
                    check = "No";
                }     
            }

            if(check == "Yes"){
                    Console.WriteLine($"\nCustomer Login Successfully");
                    SubMenu();
            }else{
                Console.WriteLine($"Invalid Customer ID");
                
            }    
        }

        public static void SubMenu(){
            string choice = "yes";
            do{

            Console.WriteLine($"\nEnter Your Choice :\n1. Purchase\n2. Order History\n3. Cancel Order\n4. Wallet Balance\n5. Exit");
            int action = int.Parse(Console.ReadLine());

            switch(action){
                case 1:{
                    Console.WriteLine($"Purchase");
                    Purchase();                    
                    break;
                }
                case 2:{
                    Console.WriteLine($"Order History"); 
                    OrderHistory();
                    break;
                }
                case 3:{
                    Console.WriteLine($"Cancel Order"); 
                    CancelOrder();
                    break;
                }
                case 4:{
                    Console.WriteLine($"Wallet Balance "); 
                    WalletBalance();
                    break;
                }
                case 5:{
                    Console.WriteLine($"Exit"); 
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");
        }

        public static void Purchase(){

            //Show to Products
            Console.WriteLine($"Our Products are below Listed : ");
            Console.WriteLine($"ProductId  ProductName  StackQuantity  PricePerQuantity  ShippingDuration ");
            foreach(ProductDetails product in productList){
                Console.WriteLine($"{product.ProductId}\t\t {product.ProductName}\t\t{product.StackQuantity}\t\t{product.PricePerQuantity}\t\t{product.ShippingDuration}");
            }            

            //get the product id
            Console.WriteLine($"Enter the Product Id to buy : ");
            string productId = Console.ReadLine();            
            
            //get Quantity
            Console.WriteLine($"Enter the Product Quantity: ");
            int quanitity = int.Parse(Console.ReadLine()); 

            //check the quanitity
            foreach(ProductDetails product in productList){
                if(productId == product.ProductId && quanitity <= product.StackQuantity){

                //Total Amount
                int deliveryCharge = 50;
                int totalAmount = (quanitity * product.PricePerQuantity )+deliveryCharge;

                //check balance is greater then total amount
                    if(loginCustomer.WalletBalance < totalAmount){
                        Console.WriteLine($"Insufficient Wallet Balance. Please recharge your wallet");                                        
                    }
                    else{
                        //after balance
                        loginCustomer.WalletBalance = loginCustomer.WalletBalance - totalAmount;
                        product.StackQuantity = product.StackQuantity - quanitity;

                        //shipping date
                        DateTime date = DateTime.Now;
                        DateTime ShippingDate = date.AddDays(product.ShippingDuration);
                        OrderDetails order = new OrderDetails(loginCustomer.CustomerId, product.ProductId, totalAmount, date, quanitity, Order.Ordered);
                        orderList.Add(order);
                        Console.WriteLine($"Order placed successfully. Your order will be delivered on {ShippingDate.ToShortDateString()}");
                    }
                }
            }



        }
        public static void OrderHistory(){
            Console.WriteLine($"OrderId  CustomerId  ProductId  TotalPrice  PurchaseDate  QuantityPurchase  OrderStatus");
            
            foreach(OrderDetails order in orderList){
                if(loginCustomer.CustomerId == order.CustomerId){
                    Console.WriteLine($"{order.OrderId}   {order.CustomerId}     {order.ProductId}\t {order.TotalPrice}\t\t{order.PurchaseDate.ToShortDateString()}\t{order.Quantity}\t\t{order.OrderStatus}");
                }   
            }
        }
        public static void CancelOrder(){
            
            //show customer order
            Console.WriteLine($"OrderID CustomerId  ProductId  TotalPrice  PurchaseDate  Quantity OrderStatus");
            foreach(OrderDetails order in orderList){
                if(loginCustomer.CustomerId == order.CustomerId){
                    Console.WriteLine($"{order.OrderId}  {order.CustomerId}\t{order.ProductId}\t{order.TotalPrice} \t {order.PurchaseDate.ToShortDateString()}  {order.Quantity}    {order.OrderStatus}");   
                }
            }
           //get orderId to cancel
            Console.WriteLine($"Enter the Order Id to cancel : ");
            string orderId = Console.ReadLine();  

            //Increase quantity
            foreach(OrderDetails order in orderList){
                if(orderId == order.OrderId){
                    foreach(ProductDetails product in productList){
                        if(order.ProductId == product.ProductId){

                            Console.WriteLine($"Your Order Cancel Successfully");
                            product.StackQuantity = product.StackQuantity + 1;
                            
                            //wallet balance
                            loginCustomer.WalletBalance = loginCustomer.WalletBalance + order.TotalPrice;

                            //change the oder details
                            order.OrderStatus = Order.Cancelled;
                        }
                    }
                }
            }
            
        }
        public static void WalletBalance(){
            Console.WriteLine($"Your Current Balance is {loginCustomer.WalletBalance}");
            Console.WriteLine($"Do you want to Recharge (Yes/No):");
            string select = Console.ReadLine();
            if(select == "Yes"){
                loginCustomer.RechargeWallet();
            }
        }
        public static void AddDefaultData(){
            ProductDetails product1 = new ProductDetails("Mobile",10,10000,3);
            productList.Add(product1);
            ProductDetails product2 = new ProductDetails("Tablet",5,15000,2);
            productList.Add(product2);
            ProductDetails product3 = new ProductDetails("Camara",3,20000,4);
            productList.Add(product3);
            ProductDetails product4 = new ProductDetails("iPhone",5,50000,6);
            productList.Add(product4);
            ProductDetails product5 = new ProductDetails("Laptop",3,50000,3);
            productList.Add(product5);

            CustomerDetails customer1 = new CustomerDetails("Ravi","chennai",9885858588,50000,"ravi@mail.com");
            customersList.Add(customer1);
            CustomerDetails customer2 = new CustomerDetails("Baskaran","chennai",9888475757,60000,"baskaran@mail.com");
            customersList.Add(customer2);

            OrderDetails order1 = new OrderDetails("CID1001","PID101",20000, DateTime.Now,2,Order.Ordered);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("CID1002","PID103",40000, DateTime.Now,2,Order.Ordered);
            orderList.Add(order2);
        }
    }
}