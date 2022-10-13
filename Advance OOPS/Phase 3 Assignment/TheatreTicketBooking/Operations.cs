using System;
using System.Collections.Generic;

namespace TheatreTicketBooking
{ 
    /// <summary>
    /// Delegate Method
    /// </summary>
    public delegate void EventManager();
    public class Operations
    {
        /// <summary>
        /// eventlink is used to Add the method to show Series order
        /// </summary>
        private static event EventManager eventlink = null;
        /// <summary>
        /// Used to Collect the Login user details
        /// </summary>
        static UserDetails currentLoginUser;

        /// <summary>
        /// This List is used to store Booking Details
        /// </summary>
        /// <typeparam name="BookingDetails"></typeparam>
        /// <returns></returns>
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        /// <summary>
        /// THis List is used to store User's Details
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns></returns>
        public static List<UserDetails> userList = new List<UserDetails>();
        /// <summary>
        /// This List is used to store Theatre's Details
        /// </summary>
        /// <typeparam name="TheatreDetails"></typeparam>
        /// <returns></returns>
        public static List<TheatreDetails> theatreList = new List<TheatreDetails>();
        /// <summary>
        /// This List is used to Store Movie's Details
        /// </summary>
        /// <typeparam name="MoviesDetails"></typeparam>
        /// <returns></returns>
        public static List<MoviesDetails> movieList = new List<MoviesDetails>();
        /// <summary>
        /// This List is used to store Screening Details
        /// </summary>
        /// <typeparam name="ScreeningMovieDetails"></typeparam>
        /// <returns></returns>
        public static List<ScreeningMovieDetails> screeningMovieList = new List<ScreeningMovieDetails>();

        /// <summary>
        /// Subcribe Method 
        /// </summary>
        public static void Subscribe(){
            // eventlink += new EventManager(DefaultData);
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFile);
            eventlink += new EventManager(MainMenu);
            eventlink += new EventManager(Files.WriteToFile);
        }

        /// <summary>
        /// Event Start Method 
        /// </summary>
        public static void EventStart(){
            Subscribe();
            eventlink();
        }
        /// <summary>
        /// MainMenu Method
        /// </summary>
        public static void MainMenu(){

            string choice = "Yes";
            do{
                Console.WriteLine($"\nWelcome to Sathyam Cinema\n ");
            Console.WriteLine($"Select your Options : \n1.	User Registration\n2.	Login\n3.	Exit");
            Console.WriteLine($"\nEnter Your Option");
            int action = int.Parse(Console.ReadLine());

            switch(action){
                case 1:{
                    UserRegiteration();
                    break;
                }
                case 2:{
                    UserLogin();
                    break;
                }
                case 3:{
                    choice = "No";
                    break;
                }
            }
            }while(choice == "Yes");            
        }
        /// <summary>
        /// Registration Method
        /// </summary>
        public static void UserRegiteration(){ 

            //Registration 
            Console.Write($"Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write($"Enter your Age : ");
            int age =int.Parse( Console.ReadLine());
            
            Console.Write($"Enter your Phone Number : ");
            long phoneNubmer =long.Parse( Console.ReadLine());
            
            Console.Write($"Enter you Balance Amount : ");
            double balance = double.Parse(Console.ReadLine());
            
            UserDetails user = new UserDetails(name,age,phoneNubmer,balance);
            userList.Add(user);
            Console.WriteLine($"\nYour User ID is : {user.UserId}");
        }

        /// <summary>
        /// User Login Method
        /// </summary>
        public static void UserLogin(){
            int flag = 0;
            Console.Write($"\nEnter your User ID : ");
            string userID = Console.ReadLine().ToUpper();

            //Check User ID isValied
            foreach(UserDetails user in userList){
                if(userID == user.UserId){
                    Console.WriteLine($"\nLogin Successfully");
                    flag =1;
                    currentLoginUser = user;
                    SubMenu();                    
                }

            }if(flag ==0){
                Console.WriteLine($"Invalid UserId");
            }
        }

        /// <summary>
        /// SubMenu Method
        /// </summary>
        public static void SubMenu(){
            string choice = "Yes";
            do{
                Console.WriteLine($"\nSelect your Options below The Sub Menu :\n1.  Ticket Booking\n2.  Ticket Cancellation \n3.  Booking History\n4.  Wallet Recharge\n5.  Exit");
            Console.WriteLine($"\nEnter Your Option");
            int action = int.Parse(Console.ReadLine());

            switch(action){
                case 1:{
                    TickectBooking();
                    break;
                }
                case 2:{
                    TickectCancel();
                    break;
                }
                case 3:{
                    BookingHistroy();
                    break;
                }
                case 4:{
                    Console.WriteLine($"Your Current Balance is : {currentLoginUser.WalletBalance} ");
                    Console.WriteLine($"Enter the Amount to Add to Balance : ");
                    double amount = double.Parse(Console.ReadLine());
                    currentLoginUser.RechargeWallet(amount);
                    break;
                }
                case 5:{
                    choice = "No";
                    break;
                }
            }
            }while(choice == "Yes"); 
        }

        /// <summary>
        /// TicketBooking Method
        /// </summary>
        public static void TickectBooking(){
            double totalAmount=0;
            //Show All Theater Datails
            Console.WriteLine($"TheatreID\t TheatreName\t TheatreLocation");
            foreach(TheatreDetails theatre in theatreList){
                theatre.ShowTheatreDetails();
            }

            //get the Theatre Id
            Console.Write($"\nEntre the Theate ID :");
            string theatreId = Console.ReadLine().ToUpper();
            
            //show list of movies screened 
            foreach(ScreeningMovieDetails screening in screeningMovieList){
                if(theatreId == screening.TheatreID){
                    Console.WriteLine($"MovieID\tMovieName\tLanguage");
                    foreach(MoviesDetails moive in movieList){
                        if(moive.MovieID == screening.MovieID){
                            moive.ShowMovieDetails();
                        }
                    }
                    Console.Write($"\nSelect the Movie List :");
                    string moiveId =Console.ReadLine().ToUpper();
                    Console.Write($"\nEnter the Number of seat :");
                    int noOfSeat =int.Parse(Console.ReadLine());

                    //check seat availablity
                    if(noOfSeat <= screening.NoOfSeatsAvailable){
                        totalAmount = (noOfSeat*screening.TicketPrice);
                        totalAmount = totalAmount +(0.18*totalAmount);
                        if(currentLoginUser.WalletBalance < totalAmount){
                            Console.WriteLine($"Insufficient Wallet Balance. Please recharge your wallet");
                            break;
                        }else{
                            currentLoginUser.WalletBalance -= totalAmount;
                            screening.NoOfSeatsAvailable -= noOfSeat;
                            BookingDetails booking = new BookingDetails(currentLoginUser.UserId,screening.MovieID,screening.TheatreID,noOfSeat,totalAmount,BookingStatus.Booked);
                            bookingList.Add(booking);
                            Console.WriteLine($"Booking successful"); 
                            break; 
                        }
                    }else{
                        Console.WriteLine($"\nRequired Seat count not available.\nCurrent availability is {screening.NoOfSeatsAvailable}");
                        break;
                    }
                }else{
                    Console.WriteLine($"Please Enter Valied ID");
                    break;
                    
                }
            }
        }
        /// <summary>
        /// Ticket Cancel Method
        /// </summary>
        public static void TickectCancel(){
            BookingHistroy();
            Console.Write($"Enter the Cancel Booking  ID : ");
            string cancelBookingId = Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList){
                if(booking.BookingID == cancelBookingId && booking.BookingStatus == BookingStatus.Booked){
                    foreach(ScreeningMovieDetails screening in screeningMovieList){
                        if(booking.MovieID == screening.MovieID){
                            screening.NoOfSeatsAvailable += booking.SeatCount; 
                            currentLoginUser.WalletBalance =currentLoginUser.WalletBalance + booking.TotalAmount - 20;
                            booking.BookingStatus = BookingStatus.Cancelled;
                            Console.WriteLine($"Cancel Booking Successfully");
                            break;
                        }
                    }
                }
            }    
            
        }

        /// <summary>
        /// Booking Histroy
        /// </summary>
        public static void BookingHistroy(){
            Console.WriteLine($"BookingID\tUserID\tMovieID\tTheatreID\tSeatCount\tTotalAmount\tBookingStatus");
            foreach(BookingDetails booking in bookingList){
                if(currentLoginUser.UserId == booking.UserID){
                    Console.WriteLine($"{booking.BookingID,-10}\t\t{booking.UserID,-10}\t{booking.MovieID,-10}\t{booking.TheatreID,-10}\t{booking.SeatCount,-10}\t{booking.TotalAmount,-10}\t{booking.BookingStatus,-10}");
                }
            }       
        }

        /// <summary>
        /// Default Data
        /// </summary>
        public static void DefaultData(){
            BookingDetails booking1 = new BookingDetails("UID1001",	"MID501",	"TID301"	,1,	200,BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("UID1001",	"MID504",	"TID302"	,1,	400,BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("UID1002",	"MID505",	"TID302"	,1,	300,BookingStatus.Booked);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);

            UserDetails user1 = new UserDetails("Ravichandran",	30,	8599488003,1000);
            UserDetails user2 = new UserDetails("Baskaran",	30,	9857747327,2000);
            userList.Add(user1);
            userList.Add(user2);

            TheatreDetails theatre1 = new TheatreDetails("Inox","Anna Nagar");
            TheatreDetails theatre2 = new TheatreDetails("Ega Theatre","Chetpet");
            TheatreDetails theatre3 = new TheatreDetails("Kamala ","Vadapalani");
            theatreList.Add(theatre1);
            theatreList.Add(theatre2);
            theatreList.Add(theatre3);

            MoviesDetails movie1 = new MoviesDetails("Bagubali 2","Telugu");
            MoviesDetails movie2 = new MoviesDetails("Ponniyin Selvan","Tamil");
            MoviesDetails movie3 = new MoviesDetails("Cobra"	,"Tamil");
            MoviesDetails movie4 = new MoviesDetails("Vikram"	,"Hindi (Dubbed)");
            MoviesDetails movie5 = new MoviesDetails("Vikram"	,"Tamil");
            MoviesDetails movie6 = new MoviesDetails("Beast"	,"English");
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            ScreeningMovieDetails screening1 = new ScreeningMovieDetails("MID501",	"TID301",	200,	5);
            ScreeningMovieDetails screening2= new ScreeningMovieDetails("MID502",	"TID301",	300,	2);
            ScreeningMovieDetails screening3= new ScreeningMovieDetails("MID506",	"TID301",	50,	    1);
            ScreeningMovieDetails screening4= new ScreeningMovieDetails("MID501",	"TID302",	400,	11);
            ScreeningMovieDetails screening5= new ScreeningMovieDetails("MID502",	"TID302",	300,	10);
            ScreeningMovieDetails screening6= new ScreeningMovieDetails("MID504",	"TID302",	500,	2);
            ScreeningMovieDetails screening7= new ScreeningMovieDetails("MID505",	"TID303",	100,	11);
            ScreeningMovieDetails screening8= new ScreeningMovieDetails("MID502",	"TID303",	200,	20);
            ScreeningMovieDetails screening9= new ScreeningMovieDetails("MID504",	"TID303",	350,	2);
            screeningMovieList.Add(screening1);
            screeningMovieList.Add(screening2);
            screeningMovieList.Add(screening3);
            screeningMovieList.Add(screening4);
            screeningMovieList.Add(screening5);
            screeningMovieList.Add(screening6);
            screeningMovieList.Add(screening7);
            screeningMovieList.Add(screening8);
            screeningMovieList.Add(screening9);

        }
    
    }
}