using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class ProductDetails
    {
        private static int s_productID =100;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public int PricePerQuantity { get; set; }

        public ProductDetails(string productName, int quantityAvailable, int pricePerQuantity){
            s_productID++;
            ProductID = "PID"+s_productID;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
        public ProductDetails(string data){
            string[] value= data.Split(',');
            s_productID = int.Parse(value[0].Remove(0,3));
            ProductID = value[0];
            ProductName = value[1];
            QuantityAvailable = int.Parse(value[2]);
            PricePerQuantity = int.Parse(value[3]);
        }

        public void ShowProductDetails(){
            Console.WriteLine($"{ProductID}\t{ProductName}\t{QuantityAvailable}\t{PricePerQuantity}");
        }
    }
}