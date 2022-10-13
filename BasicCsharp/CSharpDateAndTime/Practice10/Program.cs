using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            DateTime yesterDay = date.AddDays(-1);
            DateTime tommorowDay = date.AddDays(1);

            Console.WriteLine($"Yesterday : {yesterDay.ToString("MM/dd/yyyy")}\nTomorrow : {tommorowDay.ToString("MM/dd/yyyy")}");

        }
    }
}