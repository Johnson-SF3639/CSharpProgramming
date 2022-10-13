using System;
namespace Practice13{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Day : ");
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "dd", null);
            Console.WriteLine($"Enter the Month Number : ");
            DateTime month = DateTime.ParseExact(Console.ReadLine(), "MM", null);
            Console.WriteLine($"Enter the Year : ");
            DateTime year = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
            DateTime totalDay = new DateTime(day.Day,month.Month,year.Year);
            Console.WriteLine($"The formatted Date is : {totalDay.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"The last day of the week for the above date is: ");
        }
    }
}