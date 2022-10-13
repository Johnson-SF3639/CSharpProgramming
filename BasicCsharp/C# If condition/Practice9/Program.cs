using System;
namespace Practice9{
    class Program{
        public static void Main(string[] args)
        {
            string month;

            Console.WriteLine("Enter You Month :");
            month = Console.ReadLine();

            if(month == "December" || month == "January" || month == "February"){
                Console.WriteLine("Winter");  
            }else if(month == "March" || month == "April" || month == "May") {
                Console.WriteLine("Spring");
            }else if(month == "June" || month == "July" || month == "August") {
                Console.WriteLine("Summer");
            }else{
                Console.WriteLine("rainfall");
            }
        }
    }
}