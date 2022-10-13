using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : DepartmentDetails
    {
        private static int s_bookId = 1000;
        public string BookID{ get; set; }
        public string BookName{ get; set; }
        public string AuthorName{ get; set; }
        public double Price{ get; set; }

        public BookInfo(string departmentName, string degree,string bookName, string authorName, double price) : base(departmentName, degree){
            s_bookId++;
            BookID = "BID"+ s_bookId;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void ShowBookDetails(){
            Console.WriteLine($"{BookID}\t{BookName}\t{AuthorName}\t\t{DepartmentName}\t\t{Degree}\t{Price}");
            
        }
    }
}