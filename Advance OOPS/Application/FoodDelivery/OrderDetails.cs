
namespace FoodDelivery
{
    public class OrderDetails
    {
        private static int s_orderId;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID, string foodID, int purchaseCount, double priceOfOrder){
            s_orderId++;
            OrderID ="OID"+s_orderId;
            BookingID = bookingID;
            FoodID = foodID;
            PurchaseCount =purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        public OrderDetails(string data){
            string[] value = data.Split(',');
            s_orderId = int.Parse(value[0].Remove(0,3));
            OrderID = value[0];
            BookingID = value[1];
            FoodID = value[2];
            PurchaseCount =int.Parse(value[3]);
            PriceOfOrder = double.Parse(value[4]);
        }

        public void ShowOrderDetails(){

        }
    }
}