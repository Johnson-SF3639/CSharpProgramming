using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            string dateStr="";
            Console.WriteLine($"Enter the Date And Time : (dd/MM/yyyy hh:mm:ss AM)");
            dateStr = Console.ReadLine();
            DateTime dates = DateTime.Parse(dateStr);
            Console.WriteLine("1. Year : "+dates.Year);
            Console.WriteLine("2. Month : "+dates.Month);
            Console.WriteLine("3. Day : "+dates.Day);
            Console.WriteLine("4. Hour : "+dates.Hour);
            Console.WriteLine("5. Minute : "+dates.Minute);
            Console.WriteLine("6. Second : "+dates.Second);
            Console.WriteLine("6. Millisecond : "+dates.Millisecond);
        }
    }
}