using System;

namespace TheatreTicketBooking
{
    /// <summary>
    /// TheatreDetails class
    /// </summary>
    public class TheatreDetails
    {
        /// <summary>
        /// private field
        /// </summary>
        private static int s_theatreId= 300;
        /// <summary>
        /// TheatreID property
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// TheatreName property
        /// </summary>
        /// <value></value>
        public string TheatreName { get; set; }
        /// <summary>
        /// TheatreLocation property
        /// </summary>
        /// <value></value>
        public string TheatreLocation { get; set; }

        /// <summary>
        /// TheatreDetails constructor
        /// </summary>
        /// <param name="theatreName"></param>
        /// <param name="theatreLocation"></param>
        public TheatreDetails(string theatreName, string theatreLocation){
            s_theatreId++;
            TheatreID = "TID"+s_theatreId;
            TheatreName = theatreName;
            TheatreLocation =theatreLocation;
        }
        /// <summary>
        /// Perametrized TheatreDetails constructor
        /// </summary>
        /// <param name="data"></param>
        public TheatreDetails(string data){
            string[] value = data.Split(',');
            s_theatreId = int.Parse(value[0].Remove(0,3));
            TheatreID = value[0];
            TheatreName = value[1];
            TheatreLocation =value[2];
        }

        /// <summary>
        /// ShowTheatreDetails method
        /// </summary>
        public void ShowTheatreDetails(){
            Console.WriteLine($"{TheatreID}\t{TheatreName}\t{TheatreLocation}");
            
        }



    }
}