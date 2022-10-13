using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerces
{
    public class ProductDetails
    {
        private  static int s_productId = 100; 
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int StackQuantity { get; set; }
        public int PricePerQuantity { get; set; }
        public int ShippingDuration { get; set; }

        public ProductDetails(string productName, int stackQuantity, int pricePerQuantity, int shippingDuration){
            s_productId++;
            ProductId = "PID"+ s_productId;
            ProductName = productName;
            StackQuantity = stackQuantity;
            PricePerQuantity = pricePerQuantity;
            ShippingDuration = shippingDuration;
        }

        
        public ProductDetails(string data){
            string[] value = data.Split(',');
            s_productId = int.Parse(value[0].Remove(0,3));
            ProductId = value[0];
            ProductName = value[1];
            StackQuantity = int.Parse(value[2]);
            PricePerQuantity =int.Parse(value[3]);
            ShippingDuration = int.Parse(value[4]);
        }
    }

}