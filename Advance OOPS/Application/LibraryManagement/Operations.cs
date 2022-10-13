using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Operations
    {
        static UserDetails loginUser = null;
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetails> bookList = new List<BookDetails>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        public static void MainMenu()
        {
            string choice = "Yes";
            do
            {
                Console.WriteLine($"Main Menu");
                Console.WriteLine($"1. User Registration\n2. User Login\n3. Exit");
                Console.WriteLine($"Enter your option");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"User Registration");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"User Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exit");
                            choice = "No";
                            break;
                        }
                }

            } while (choice == "Yes");
        }

        public static void Registration()
        {
            Console.WriteLine($"Enter User Name");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.WriteLine($"Enter Department");
            Department department = Enum.Parse<Department>(Console.ReadLine(), true);

            Console.WriteLine($"Enter Mobile Number");
            long moblieNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Mail ID");
            string mail = Console.ReadLine();

            UserDetails user = new UserDetails(name, gender, department, moblieNumber, mail);
            userList.Add(user);

            Console.WriteLine($"Your User ID is {user.RegisterId}");

        }

        public static void Login()
        {
            Console.WriteLine($"Enter your User ID :");
            string userId = Console.ReadLine();

            int check = 0;
            foreach (UserDetails user in userList)
            {
                if (userId == user.RegisterId)
                {
                    check = 1;
                    Console.WriteLine($"Login Successfully");
                    loginUser = user;
                    SubMenu();
                }
            }
            if (check == 0)
            {
                Console.WriteLine($"Invalid User ID. Please enter a valid one");
            }
        }

        public static void SubMenu()
        {
            string choice = "Yes";
            do
            {
                Console.WriteLine($"Sub Menu");
                Console.WriteLine($"1. Borrow book\n2. Show Borrowed history\n3. Return Books \n4. Exit");
                Console.WriteLine($"Enter your option");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"Borrow book");
                            BorrowBook();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Show Borrowed history");
                            ShowBorrowedhistory();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Return Books");
                            ReturnBook();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Exit");
                            choice = "No";
                            break;
                        }
                }

            } while (choice == "Yes");
        }

        public static void BorrowBook()
        {
            //Show Book 
            Console.WriteLine($"List of Books");
            Console.WriteLine($"BookId\t  BookName\t  AuthorName  \tNoOfBooks");
            foreach (BookDetails book in bookList)
            {
                Console.WriteLine($"{book.BookId} \t {book.BookName} \t {book.AuthorName} \t {book.NoOfBooks}");
            }

            //get book ID
            Console.WriteLine($"Enter Book ID to borrow");
            string bookId = Console.ReadLine();

            //check count 
            foreach (BookDetails book in bookList)
            {
                if (bookId == book.BookId)
                {
                    if (book.NoOfBooks <= 0)
                    {
                        Console.WriteLine($"Books are not available for the selected count");
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            if (bookId == borrow.BookId)
                            {
                                DateTime date = borrow.BorrowDate.AddDays(15);
                                Console.WriteLine($"The book will be available on {date.ToShortDateString()}");
                            }
                        }
                    }
                    else
                    {
                        int value = CheckCountTime();
                        if (value <= 3)
                        {
                            Console.WriteLine($"You can take the Book");
                            book.NoOfBooks = book.NoOfBooks - 1;
                            BorrowDetails borrowBook = new BorrowDetails(bookId, loginUser.RegisterId, DateTime.Now, Status.Assigned);
                            borrowList.Add(borrowBook);
                        }
                        else
                        {
                            Console.WriteLine("You have more then Enough books");
                        }
                    }
                }
            }
        }

        public static void ReturnBook()
        {
            int checkValue = 0;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (loginUser.RegisterId == borrow.RegisterId && borrow.Status == Status.Assigned)
                {
                    DateTime returnDate = borrow.BorrowDate.AddDays(15);

                    int result = DateTime.Compare(returnDate, DateTime.Now);
                    // Check Due date
                    if (result > 0){
                        Console.WriteLine($"Your Book ID {borrow.BookId} and It's Return Date {returnDate.ToShortDateString()}");
                    }
                    else{
                        checkValue = checkCountDates(returnDate);
                    }
                    if (checkValue > 0){
                        Console.WriteLine($"You Will pay the fine Amount is {checkValue * 1} for this book {borrow.BookId}");
                        Console.WriteLine($"Enter The Fine Amount");
                        int pay = int.Parse(Console.ReadLine());
                        if (pay == checkValue)
                        {
                            borrow.Status = Status.Returned;
                        }
                    }
                }
            }
        }
        public static int checkCountDates(DateTime date)
        {
            int increase = 1;
            while (true){
                string check1 = date.AddDays(increase).ToLongDateString().ToString();
                string check2 = DateTime.Now.ToLongDateString().ToString();
                if (check1 == check2){
                    return increase;
                }
                increase++;
            }
        }
        public static int CheckCountTime()
        {
            int count = 1;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (loginUser.RegisterId == borrow.RegisterId && borrow.Status == Status.Assigned)
                {
                    count++;
                }
            }
            return count;
        }
        public static void ShowBorrowedhistory()
        {
            Console.WriteLine($"BorrowBookId    BookId   RegisterId   BorrowDate  Borrow Status");
            foreach (BorrowDetails borrow in borrowList)
            {
                if (loginUser.RegisterId == borrow.RegisterId)
                {
                    Console.WriteLine($"{borrow.BorrowBookId}\t{borrow.BookId}\t{borrow.RegisterId}\t{borrow.BorrowDate.ToShortDateString()}\t{borrow.Status}");
                }
            }
        }
        public static void DefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", Gender.Male, Department.EEE, 9938388333, "ravi@gmail.com");
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Priyadharshini", Gender.Female, Department.CSE, 9944444455, "priya@gmail.com");
            userList.Add(user2);

            BookDetails book1 = new BookDetails("C#", "Author1", 3);
            bookList.Add(book1);
            BookDetails book2 = new BookDetails("HTML", "Author2", 5);
            bookList.Add(book2);
            BookDetails book3 = new BookDetails("CSS", "Author1", 3);
            bookList.Add(book3);
            BookDetails book4 = new BookDetails("JS", "Author1", 3);
            bookList.Add(book4);
            BookDetails book5 = new BookDetails("TS", "Author2", 2);
            bookList.Add(book5);

            BorrowDetails borrow1 = new BorrowDetails("BID101", "SF3001", new DateTime(2022, 04, 10), Status.Assigned);
            borrowList.Add(borrow1);
            BorrowDetails borrow2 = new BorrowDetails("BID103", "SF3001", new DateTime(2022, 04, 12), Status.Returned);
            borrowList.Add(borrow2);
            BorrowDetails borrow3 = new BorrowDetails("BID104", "SF3001", new DateTime(2022, 04, 15), Status.Assigned);
            borrowList.Add(borrow3);
            BorrowDetails borrow4 = new BorrowDetails("BID102", "SF3002", new DateTime(2022, 04, 11), Status.Returned);
            borrowList.Add(borrow4);
            BorrowDetails borrow5 = new BorrowDetails("BID105", "SF3002", new DateTime(2022, 04, 15), Status.Returned);
            borrowList.Add(borrow5);
        }


    }
}