using System;
namespace DateAndTimeAssignment{
    class Program{
        public static void Main(string[] args)
        {
            DateTime dob = new DateTime(2000,12,10,01,59,59);
            Console.WriteLine("Year : "+dob.Year);
            Console.WriteLine("Month : "+dob.Month);
            Console.WriteLine("Day : "+dob.Day);
            Console.WriteLine("Hour : "+dob.Hour);
            Console.WriteLine("Minute : "+dob.Minute);
            Console.WriteLine("Second : "+dob.Second);

            string convertToString = dob.ToString("yyyy/mm/dd HH:MM:ss tt");
            Console.WriteLine("Date and Time Converted by String : "+convertToString);

            string[] spliter = convertToString.Split(new string[]{"/"," ",":"},StringSplitOptions.None);
            for(int i=spliter.Length-1; i>=0; i--){
                Console.Write(" "+spliter[i]);
            }

        }
    }
}