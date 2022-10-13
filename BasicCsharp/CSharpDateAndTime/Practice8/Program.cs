using System;
namespace Practice8{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2016,08,20,12,00,00);  
            DateTime beforeYear = date1.AddYears(-1);
            DateTime afterYear = date1.AddYears(1);
            int compare1 = DateTime.Compare(afterYear,date1);
            int compare2 = DateTime.Compare(beforeYear,date1);
            if(compare1<0){
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy")} is earlier then {beforeYear.ToString("MM:dd:yyyy")}");
            }else{
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy")} is Later then {beforeYear.ToString("MM:dd:yyyy")}");
            }
            if(compare2<0){
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy")} is earlier then {afterYear.ToString("MM:dd:yyyy")}");
            }else{
                Console.WriteLine($"{date1.ToString("MM:dd:yyyy")} is Later then {afterYear.ToString("MM:dd:yyyy")}");
            }
        }
    }
}