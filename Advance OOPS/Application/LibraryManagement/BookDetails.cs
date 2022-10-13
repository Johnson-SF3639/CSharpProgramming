using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BookDetails{
        private static int s_bookId = 100;
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int NoOfBooks { get; set; }

        public BookDetails(string bookName, string authorName, int noOfBooks){
            s_bookId++;
            BookId ="BID" + s_bookId;
            BookName = bookName;
            AuthorName =authorName;
            NoOfBooks = noOfBooks;
        }
        
    }
}