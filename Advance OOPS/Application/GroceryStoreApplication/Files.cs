using System;
using System.IO;

namespace GroceryStoreApplication
{
    public class Files
    {
        public static void Create(){
            try{
                if(!Directory.Exists("Details")){
                    Console.WriteLine($"Folder Created Successfully");
                    Directory.CreateDirectory("Details");
                }
                if(!File.Exists("Details/CustomerDetails.csv")){
                    Console.WriteLine($"File Created");
                    File.Create("Details/CustomerDetails.csv");
                }
                if(!File.Exists("Details/OrderDetails.csv")){
                    Console.WriteLine($"File Created");
                    File.Create("Details/OrderDetails.csv");
                }
                if(!File.Exists("Details/ProductDetails.csv")){
                    Console.WriteLine($"File Created");
                    File.Create("Details/ProductDetails.csv");
                }
                if(!File.Exists("Details/BookingDetails.csv")){
                    Console.WriteLine($"File Created");
                    File.Create("Details/BookingDetails.csv");
                }
            }catch(FileNotFoundException e){
                Console.WriteLine($"Error : {e}");
            }
        }

        
        public static void ReadFile(){
            string[] customerDetails = File.ReadAllLines("Details/CustomerDetails.csv");
            foreach(string data in customerDetails){
                CustomerDetails customer = new CustomerDetails(data);
                Operations.customerList.Add(customer);
            }
            
            string[] orderDetails = File.ReadAllLines("Details/OrderDetails.csv");
            foreach(string data in orderDetails){
                OrderDetails order = new OrderDetails(data);
                Operations.orderList.Add(order);
            }
            
            string[] productDetails = File.ReadAllLines("Details/ProductDetails.csv");
            foreach(string data in productDetails){
                ProductDetails product = new ProductDetails(data);
                Operations.productList.Add(product);
            }

            string[] bookingDetails = File.ReadAllLines("Details/BookingDetails.csv");
            foreach(string data in bookingDetails){
                BookingDetails booking = new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }
        }

        
        public static void WriteFile(){

            string[] customer = new string[Operations.customerList.Count];
            for(int i=0; i<Operations.customerList.Count; i++){
                customer[i] = Operations.customerList[i].CustomerID + ',' +Operations.customerList[i].Name + ',' +Operations.customerList[i].FatherName + ',' +Operations.customerList[i].Gender + ',' +Operations.customerList[i].Mobile + ',' +Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+ ',' +Operations.customerList[i].MailID+ ',' +Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Details/CustomerDetails.csv",customer);

            string[] product = new string[Operations.productList.Count];
            for(int i=0; i<Operations.productList.Count; i++){
                product[i] = Operations.productList[i].ProductID + ',' +Operations.productList[i].ProductName + ',' +  Operations.productList[i].QuantityAvailable + ',' +Operations.productList[i].PricePerQuantity; 
            }
            File.WriteAllLines("Details/ProductDetails.csv",product);

            string[] order = new string[Operations.orderList.Count];
            for(int i=0; i<Operations.orderList.Count; i++){
                order[i] = Operations.orderList[i].OrderID + ',' +Operations.orderList[i].BookingID + ',' +  Operations.orderList[i].ProductID + ',' +Operations.orderList[i].PurchaseCount + ',' +Operations.orderList[i].PriceOfOrder; 
            }
            File.WriteAllLines("Details/orderDetails.csv",order);

            string[] booking = new string[Operations.bookingList.Count];
            for(int i=0; i<Operations.bookingList.Count; i++){
                booking[i] = Operations.bookingList[i].BookingID + ',' +Operations.bookingList[i].CustomerID + ',' +  Operations.bookingList[i].TotalPrice + ',' +Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy") + ',' +Operations.bookingList[i].BookingStatus; 
            }
            File.WriteAllLines("Details/bookingDetails.csv",booking);
        }


    }
}