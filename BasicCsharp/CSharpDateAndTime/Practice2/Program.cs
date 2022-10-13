using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            string dateStr="";
            Console.WriteLine($"Enter the Date And Time : (dd/MM/yyyy hh:mm:ss AM)");
            dateStr = Console.ReadLine();
            DateTime dates = DateTime.Parse(dateStr);
            Console.WriteLine("1. Complete date : "+dates.ToString("dd/MM/yyyy hh:mm:ss tt"));
            Console.WriteLine("2. Short Date : "+dates.ToShortDateString());
            Console.WriteLine("3. "+dates.ToLongDateString()+" "+dates.ToLongTimeString());
            Console.WriteLine("4. "+dates.ToString("dd/MM/yyyy hh:mm tt"));
            Console.WriteLine("5. "+dates.ToString("dd/MM/yyyy"));
            Console.WriteLine("6. "+dates.ToString("hh/mm/ss tt"));
        }
    }
}