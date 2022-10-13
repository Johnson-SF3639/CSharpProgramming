using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            DateTime dates = DateTime.Now;  
            
            Console.WriteLine($"Today = {dates.ToString("MM:dd:yyyy HH:mm:ss tt")}");

            DateTime addYear = dates.AddDays(40);
            
            Console.WriteLine($"After 40 Days : {dates.DayOfWeek}");
        }
    }
}