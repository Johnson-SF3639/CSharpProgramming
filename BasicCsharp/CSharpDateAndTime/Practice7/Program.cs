using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2022,12,23,12,10,05);  
            DateTime date2 = new DateTime(2022,12,23,00,10,05);  
            int compare = DateTime.Compare(date1,date2);
            if(compare == 0){
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy HH:mm:ss tt")} is same time as {date2.ToString("MM:dd:yyyy HH:mm:ss tt")}");
            }else if(compare<0){
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy HH:mm:ss tt")} is earlier then {date2.ToString("MM:dd:yyyy HH:mm:ss tt")}");
            }else{
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy HH:mm:ss tt")} is later then {date2.ToString("MM:dd:yyyy HH:mm:ss tt")}");
            }
        }
    }
}