using System;
using System.IO;

namespace TheatreTicketBooking
{
    public class Files
    {
        /// <summary>
        /// Create Method
        /// </summary>
        public static void Create(){
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Folder Create Successfully");
                Directory.CreateDirectory("Details");                
            }
            if(!File.Exists("Details/UserDetails.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/UserDetails.csv");  
            }
            if(!File.Exists("Details/BookingDetails.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/BookingDetails.csv");  
            }
            if(!File.Exists("Details/MoviesDetails.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/MoviesDetails.csv");  
            }
            if(!File.Exists("Details/TheatreDetails.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/TheatreDetails.csv");  
            }
            if(!File.Exists("Details/ScreeningDetails.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/ScreeningDetails.csv");  
            }
        }
        /// <summary>
        /// ReadFile Method
        /// </summary>
        public static void ReadFile(){
            string[] userDetails = File.ReadAllLines("Details/UserDetails.csv");
            foreach(string data in userDetails){
                UserDetails user = new UserDetails(data);
                Operations.userList.Add(user);
            }

            string[] bookingDetails = File.ReadAllLines("Details/BookingDetails.csv");
            foreach(string data in bookingDetails){
                BookingDetails booking = new BookingDetails(data);
                Operations.bookingList.Add(booking);                
            }

            string[] moviesDetails = File.ReadAllLines("Details/MoviesDetails.csv");
            foreach(string data in moviesDetails){
                MoviesDetails movie = new MoviesDetails(data);
                Operations.movieList.Add(movie); 
            }

            string[] screeningDetails = File.ReadAllLines("Details/ScreeningDetails.csv");
            foreach(string data in screeningDetails){
                ScreeningMovieDetails screening = new ScreeningMovieDetails(data);
                Operations.screeningMovieList.Add(screening); 
            }

            string[] theatreDetails = File.ReadAllLines("Details/TheatreDetails.csv");
            foreach(string data in theatreDetails){
                TheatreDetails theatre = new TheatreDetails(data);
                Operations.theatreList.Add(theatre); 
            }
        }

        /// <summary>
        /// WriteToFile Method
        /// </summary>
        public static void WriteToFile(){
            string[] user = new string[Operations.userList.Count];
            for(int i=0; i<Operations.userList.Count; i++){
                user[i] = Operations.userList[i].UserId +","+ Operations.userList[i].Name +","+ Operations.userList[i].Age  +","+ Operations.userList[i].PhoneNumber  +","+ Operations.userList[i].WalletBalance; 
            }
            File.WriteAllLines("Details/UserDetails.csv",user);
            
            string[] booking = new string[Operations.bookingList.Count];
            for(int i=0; i<Operations.bookingList.Count; i++){
                booking[i] = Operations.bookingList[i].BookingID +","+ Operations.bookingList[i].UserID +","+ Operations.bookingList[i].MovieID  +","+ Operations.bookingList[i].TheatreID  +","+ Operations.bookingList[i].SeatCount  +","+ Operations.bookingList[i].TotalAmount  +","+ Operations.bookingList[i].BookingStatus ; 
            }
            File.WriteAllLines("Details/BookingDetails.csv",booking);

            string[] movie = new string[Operations.movieList.Count];
            for(int i=0; i<Operations.movieList.Count; i++){
                movie[i] = Operations.movieList[i].MovieID +","+ Operations.movieList[i].MovieName +","+ Operations.movieList[i].Language; 
            }
            File.WriteAllLines("Details/MoviesDetails.csv",movie);

            string[] screeningMovie = new string[Operations.screeningMovieList.Count];
            for(int i=0; i<Operations.screeningMovieList.Count; i++){
                screeningMovie[i] = Operations.screeningMovieList[i].MovieID +","+ Operations.screeningMovieList[i].TheatreID +","+ Operations.screeningMovieList[i].TicketPrice  +","+ Operations.screeningMovieList[i].NoOfSeatsAvailable; 
            }
            File.WriteAllLines("Details/ScreeningDetails.csv",screeningMovie);

            string[] theatre = new string[Operations.theatreList.Count];
            for(int i=0; i<Operations.theatreList.Count; i++){
                theatre[i] = Operations.theatreList[i].TheatreID +","+ Operations.theatreList[i].TheatreName +","+ Operations.theatreList[i].TheatreLocation; 
            }
            File.WriteAllLines("Details/TheatreDetails.csv",theatre);
        }

    }
}