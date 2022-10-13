using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            DateTime dates = new DateTime(2022,12,31);
            for(int i=0; i<8; i++){            
                DateTime addYear = dates.AddYears(i);
                Console.Write($"\n{addYear.ToShortDateString()} : day {addYear.DayOfYear} of {addYear.Year}");
                if(DateTime.IsLeapYear(addYear.Year)){
                    Console.WriteLine($" (Leap year)");
                }
            }
        }
    }
}