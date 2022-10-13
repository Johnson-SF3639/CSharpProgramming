using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Status {Default, Returned, Assigned}
    public class BorrowDetails
    {
        private static int s_borrowBookId = 300;
        public string BorrowBookId { get; set; }
        public string BookId { get; set; }
        public string RegisterId { get; set; }
        public DateTime BorrowDate { get; set; }
        public Status Status { get; set; }

        public BorrowDetails(string bookId, string registerId, DateTime borrowDate, Status status){
            s_borrowBookId++;
            BorrowBookId ="LB" + s_borrowBookId;
            BookId = bookId;
            RegisterId =registerId;
            BorrowDate = borrowDate;
            Status = status;
        }
        
    }
}