using System;
namespace Practice12{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Month Number : ");
            DateTime month = DateTime.ParseExact(Console.ReadLine(), "MM", null);
            Console.WriteLine($"Enter the Year : ");
            DateTime year = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
            int totalDay = DateTime.DaysInMonth(year.Year,month.Month);
            Console.WriteLine($"The Number of days in the month {month.ToString("MMMM")} is : {totalDay} ");
        }
    }
}