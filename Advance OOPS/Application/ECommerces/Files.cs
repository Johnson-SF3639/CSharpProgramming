using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ECommerces
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
            }catch(FileNotFoundException e){
                Console.WriteLine($"Error : {e}");
            }
        }

        public static void ReadFile(){
            string[] customerDetails = File.ReadAllLines("Details/CustomerDetails.csv");
            foreach(string data in customerDetails){
                CustomerDetails customer = new CustomerDetails(data);
                Operation.customersList.Add(customer);
            }
            
            string[] orderDetails = File.ReadAllLines("Details/orderDetails.csv");
            foreach(string data in orderDetails){
                OrderDetails order = new OrderDetails(data);
                Operation.orderList.Add(order);
            }
            
            string[] productDetails = File.ReadAllLines("Details/ProductDetails.csv");
            foreach(string data in productDetails){
                ProductDetails product = new ProductDetails(data);
                Operation.productList.Add(product);
            }
        }
        
        public static void WriteFile(){

            string[] customer = new string[Operation.customersList.Count];
            for(int i=0; i<Operation.customersList.Count; i++){
                customer[i] = Operation.customersList[i].CustomerId + ',' +Operation.customersList[i].CustomerName + ',' +Operation.customersList[i].City + ',' +Operation.customersList[i].MobileNumber + ',' +Operation.customersList[i].WalletBalance + ',' +Operation.customersList[i].EmailId; 
            }
            File.WriteAllLines("Details/CustomerDetails.csv",customer);

            string[] product = new string[Operation.productList.Count];
            for(int i=0; i<Operation.productList.Count; i++){
                product[i] = Operation.productList[i].ProductId + ',' +Operation.productList[i].ProductName + ',' +  Operation.productList[i].StackQuantity + ',' +Operation.productList[i].PricePerQuantity + ',' +Operation.productList[i].ShippingDuration; 
            }
            File.WriteAllLines("Details/ProductDetails.csv",product);

            string[] order = new string[Operation.orderList.Count];
            for(int i=0; i<Operation.orderList.Count; i++){
                order[i] = Operation.orderList[i].OrderId + ',' +Operation.orderList[i].CustomerId + ',' +  Operation.orderList[i].ProductId + ',' +Operation.orderList[i].TotalPrice + ',' +Operation.orderList[i].PurchaseDate   + ',' + Operation.orderList[i].Quantity + ',' + Operation.orderList[i].OrderStatus ; 
            }
            File.WriteAllLines("Details/OrderDetails.csv",order);
        }


    }
}