using System;
namespace OnlineLibrary{
    class Program{
        public static void Main(string[] args)
        {
            BookInfo book = new BookInfo("MECH","B.E","Life of Pie","Unknown",300);
            Console.WriteLine($"BookID\tBookName\tAuthorame\tDepartentName\tDegree\tPrice");
            book.ShowBookDetails();
        }
    }
}