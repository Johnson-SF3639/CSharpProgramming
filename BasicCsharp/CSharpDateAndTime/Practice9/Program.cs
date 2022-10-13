using System;
namespace Practice9{
    class Program{
        public static void Main(string[] args)
        {
            int startYear=1994, endYear=2014;
            for(int i= startYear; i<=endYear; i++){
                if(DateTime.IsLeapYear(i)){
                    Console.WriteLine($"{i} is Leap year.");
                    DateTime date= new DateTime(i,2,29);
                    DateTime addyear = date.AddYears(1);
                    Console.WriteLine($"One year from {date.ToString("MM/dd/yyyy")} is {addyear.ToString("MM/dd/yyyy")}");
                    
                }
            }
        }
    }
}