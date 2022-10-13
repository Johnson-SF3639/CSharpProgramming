using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class OrderDetails
    {
        private static int s_orderID =100;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        public OrderDetails(string bookingID,string productID, int purchaseCount,int priceOfOrder){
            s_orderID++;
            OrderID ="OID"+ s_orderID;
            BookingID = bookingID;
            ProductID =productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        public OrderDetails(string data){
            string[] value= data.Split(',');
            s_orderID = int.Parse(value[0].Remove(0,3));
            OrderID =value[0];
            BookingID = value[1];
            ProductID =value[2];
            PurchaseCount = int.Parse(value[3]);
            PriceOfOrder = int.Parse(value[4]);
        }
        
        public void ShowOrderDetails(){
            Console.WriteLine($"{OrderID} {BookingID} {ProductID} {PurchaseCount} {PriceOfOrder}");
        }
    }
}