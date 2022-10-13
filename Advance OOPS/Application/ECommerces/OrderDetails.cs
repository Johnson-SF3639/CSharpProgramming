using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerces
{
    public enum Order {Default, Ordered, Cancelled}
    public class OrderDetails
    {
        private  static int s_orderId = 1000; 
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public Order OrderStatus { get; set; }

        public OrderDetails(string customerId, string productId, double totalPrice, DateTime purchaseDate, int quantity, Order orderStatus){
            s_orderId++;
            OrderId = "OID"+ s_orderId;
            CustomerId = customerId;
            ProductId = productId;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }
        public OrderDetails(string data){
            string[] value = data.Split(',');
            s_orderId = int.Parse(value[0].Remove(0,3)) ;
            OrderId = value[0];
            CustomerId = value[1];
            ProductId = value[2];
            TotalPrice = double.Parse(value[3]);
            PurchaseDate =DateTime.Parse(value[4]);
            Quantity = int.Parse(value[5]);
            OrderStatus = Enum.Parse<Order>(value[6]);
        }
    }
}