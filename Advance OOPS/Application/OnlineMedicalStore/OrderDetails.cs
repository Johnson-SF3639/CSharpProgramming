using System;

namespace OnlineMedicalStore
{
    public enum Status {Default, Purchased, Cancelled}
    public class OrderDetails
    {
        private static int s_orderId =2001;
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Status OrderStatus { get; set; }

        public OrderDetails(string userID, string medicineID, int medicineCount, double totalPrice, DateTime orderDate, Status orderStatus){
            s_orderId++;
            OrderID = "OID"+ s_orderId;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount =medicineCount;
            TotalPrice =totalPrice;
            OrderDate= orderDate;
            OrderStatus = orderStatus;
        }
        public OrderDetails(string data){
            string[] value = data.Split(",");
            s_orderId =int.Parse(value[0].Remove(0,3));
            OrderID = value[0];
            UserID = value[1];
            MedicineID = value[2];
            MedicineCount =int.Parse(value[3]);
            TotalPrice =double.Parse(value[4]);
            OrderDate= DateTime.Parse(value[5]);
            OrderStatus = Enum.Parse<Status>(value[6]);
        }
    }
}