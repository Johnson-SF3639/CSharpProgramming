using System;

namespace TheatreTicketBooking
{
    /// <summary>
    /// Enum Options
    /// </summary>
    public enum BookingStatus{Default,Booked, Cancelled}
    /// <summary>
    /// BookingDetails Class
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// Auto increament ID
        /// </summary>
        private static int s_bookingId =  7001;

        /// <summary>
        /// Booking Property
        /// </summary>
        /// <value></value>
        public string BookingID { get; set; }
        /// <summary>
        /// User Property
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// MovieID Property
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// TheatreID Property
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// SeatCount Property
        /// </summary>
        /// <value></value>
        public int SeatCount { get; set; }
        /// <summary>
        /// TotalAmount Property
        /// </summary>
        /// <value></value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// BookingStatus Property
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus { get; set; }
        
        /// <summary>
        /// BookingDetails Constructor
        /// </summary>
        /// <param name="userId">User's Id</param>
        /// <param name="movieId">Movie's Id</param>
        /// <param name="theatreID">Theatre Id</param>
        /// <param name="seatCount">Seat's Count</param>
        /// <param name="totalAmount">Total Amount</param>
        /// <param name="bookingStatus">Booking Status</param>
        public BookingDetails(string userId, string movieId, string theatreID, int seatCount, double totalAmount,BookingStatus bookingStatus){
            s_bookingId++;
            BookingID ="BID"+s_bookingId;
            UserID = userId;
            MovieID = movieId;
            TheatreID= theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
        }
        /// <summary>
        /// BookingDetails Parameter Constructor
        /// </summary>
        /// <param name="data"></param>
        public BookingDetails(string data){
            string[] value = data.Split(',');
            s_bookingId = int.Parse(value[0].Remove(0,3));
            BookingID =value[0];
            UserID = value[1];
            MovieID = value[2];
            TheatreID= value[3];
            SeatCount = int.Parse(value[4]);
            TotalAmount = double.Parse(value[5]);
            BookingStatus = Enum.Parse<BookingStatus>(value[6]);
        }

    }
}