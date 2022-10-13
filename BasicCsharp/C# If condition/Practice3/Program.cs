using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4 == 0){
                Console.WriteLine($"{year} is a leap year");
            }else{
                Console.WriteLine($"{year} is not a leap year");
            }

        }
    }
}