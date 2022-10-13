using System;
namespace Practice11{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"Display the name of the months of a year : ");
            DateTime date = DateTime.Now;
            Console.WriteLine($"The date of Today : {date.ToShortDateString()} ");
            Console.WriteLine($"The twelve months are : ");
            for(int i=0; i<12; i++){
                Console.WriteLine($"{date.ToString("MMMM")}");
                date = date.AddMonths(1);
            }
        }
    }
}