using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            string dateStr="";
            Console.WriteLine($"Enter the Date And Time : (dd/MM/yyyy )");
            dateStr = Console.ReadLine();
            DateTime dates = DateTime.Parse(dateStr);
            Console.WriteLine("The day of the week for {0} is {1}",dates.ToShortDateString(),dates.DayOfWeek);
        }
    }
}