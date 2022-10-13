using System;

namespace FoodDelivery
{
    public enum BookingStatus {Default, Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookId = 3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus){
            s_bookId++;
            BookingID= "BID"+s_bookId;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking =dateOfBooking;
            BookingStatus =bookingStatus;
        }



        public void ShowBookingDetails(){

        }
    }
}