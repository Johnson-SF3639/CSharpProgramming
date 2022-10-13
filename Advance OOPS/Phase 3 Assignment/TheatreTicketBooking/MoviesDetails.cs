using System;

namespace TheatreTicketBooking
{
    /// <summary>
    /// MoviesDetails class
    /// </summary>
    public class MoviesDetails
    {
        /// <summary>
        /// private field
        /// </summary>
        private static int s_movieId= 500;
        /// <summary>
        /// MovieID Property
        /// </summary>
        /// <value></value>
        public string MovieID  { get; set; }
        /// <summary>
        /// MovieName porperty
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        /// Language property
        /// </summary>
        /// <value></value>
        public string Language { get; set; }

        /// <summary>
        /// MoviesDetails constructor
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="language"></param>
        public MoviesDetails(string movieName, string language){
            s_movieId++;
            MovieID = "MID"+s_movieId;
            MovieName = movieName;
            Language = language;
        }
        /// <summary>
        /// Praameter MoviesDetails constructor
        /// </summary>
        /// <param name="data"></param>
        public MoviesDetails(string data){
            string[] value = data.Split(',');
            s_movieId = int.Parse(value[0].Remove(0,3));
            MovieID = value[0];
            MovieName = value[1];
            Language = value[2];
        }
        /// <summary>
        /// ShowMovieDetails Method
        /// </summary>
        public void ShowMovieDetails(){
            Console.WriteLine($"{MovieID}\t{MovieName}\t{Language}");
            
        }
    }
}