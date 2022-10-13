using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public enum BookingStatus { Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID = 3001;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus){
            s_bookingID++;
            BookingID = "BID" +s_bookingID;
            CustomerID = customerID;
            TotalPrice =totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;   
        }

        public BookingDetails(string data){
            string[] value= data.Split(',');
            s_bookingID = int.Parse(value[0].Remove(0,3));
            BookingID = value[0];
            CustomerID = value[1];
            TotalPrice =int.Parse(value[2]);
            DateOfBooking = DateTime.Parse(value[3]);
            BookingStatus =Enum.Parse<BookingStatus>(value[4]);   
        }

        public void ShowBookingDetails(){
            Console.WriteLine($"{BookingID}  {CustomerID}  {TotalPrice}  {DateOfBooking.ToShortDateString()}   {BookingStatus}");
        }
        
    }
}