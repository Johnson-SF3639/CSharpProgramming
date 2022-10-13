using System;
using System.IO;

namespace FoodDelivery
{
    public static class Files
    {
        public static void Create(){
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("Details");                
            }
            if(!File.Exists("Details/CustomerDetails.csv")){
                Console.WriteLine($"Creating Customer File");
                File.Create("Details/CustomerDetails.csv");                
            }
            if(!File.Exists("Details/BookingDetails.csv")){ 
                Console.WriteLine($"Creating Booking File");
                File.Create("Details/BookingDetails.csv");                
            }
            if(!File.Exists("Details/ProductDetails.csv")){
                Console.WriteLine($"Creating Product File");
                File.Create("Details/ProductDetails.csv");                
            }
            if(!File.Exists("Details/OrderDetails.csv")){
                Console.WriteLine($"Creating Order File");
                File.Create("Details/OrderDetails.csv");                
            }
        }   

        public static void ReadFile(){
            string[] customerDetails = File.ReadAllLines("Details/CustomerDetails.csv");
            foreach(string data in customerDetails){
                CustomerDetails customer = new CustomerDetails(data);
                Operations.customerList.Add(customer);
            }

            string[] ProductDetails = File.ReadAllLines("Details/ProductDetails.csv");
            foreach(string data in ProductDetails){
                ProductDetails product = new ProductDetails(data);
                Operations.productList.Add(product);
            }

            string[] OrderDetails = File.ReadAllLines("Details/OrderDetails.csv");
            foreach(string data in OrderDetails){
                OrderDetails order = new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }     

        public static void WriteToFile(){
            string[] CustomerDetails = new string[Operations.customerList.Count];
            for(int i =0; i<Operations.customerList.Count; i++){
                CustomerDetails[i] = Operations.customerList[i].CustomerID +","+Operations.customerList[i].Name +","+Operations.customerList[i].FatherName +","+Operations.customerList[i].Gender +","+Operations.customerList[i].MobileNumber +","+Operations.customerList[i].DOB +","+Operations.customerList[i].MailID +","+Operations.customerList[i].Location+","+ Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Details/CustomerDetails.csv",CustomerDetails);
            
            string[] productDetails = new string[Operations.productList.Count];
            for(int i =0; i<Operations.productList.Count; i++){
                productDetails[i] = Operations.productList[i].FoodID +","+Operations.productList[i].FoodName +","+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("Details/ProductDetails.csv",productDetails);
            
            string[] bookingDetails = new string[Operations.bookingList.Count];
            for(int i =0; i<Operations.bookingList.Count; i++){
                bookingDetails[i] = Operations.bookingList[i].BookingID +","+Operations.bookingList[i].CustomerID +","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("Details/bookingDetails.csv",bookingDetails);
        }
    }
}