
namespace TheatreTicketBooking
{
    /// <summary>
    /// ScreeningMovieDetails class
    /// </summary>
    public class ScreeningMovieDetails
    {
        /// <summary>
        /// MovieID property
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// TheatreID property
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// NoOfSeatsAvailable property
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable { get; set; }
        /// <summary>
        /// TicketPrice Property
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }

        /// <summary>
        /// ScreeningMovieDetails Constructor
        /// </summary>
        /// <param name="movieID">movie's ID</param>
        /// <param name="theatreID">theatre's ID</param>
        /// <param name="ticketPrice">ticket Price</param>
        /// <param name="noOfSeatsAvailable">no Of Seats Available</param>
        public ScreeningMovieDetails(string movieID, string theatreID,  double ticketPrice, int noOfSeatsAvailable){
            MovieID = movieID;
            TheatreID = theatreID;
            TicketPrice =ticketPrice;
            NoOfSeatsAvailable = noOfSeatsAvailable;
        }
        /// <summary>
        /// Perameter ScreeningMovieDetails  Constructor
        /// </summary>
        /// <param name="data"></param>
        public ScreeningMovieDetails(string data){
            string[] value = data.Split(',');
            MovieID = value[0];
            TheatreID = value[1];
            TicketPrice =double.Parse( value[2]);
            NoOfSeatsAvailable =int.Parse(value[3]);
        }
    }
}