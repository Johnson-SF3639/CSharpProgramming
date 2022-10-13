using System;
namespace Question5{
    class Program{
        public static void Main(string[] args)
        {
            int year;
            Console.Write($"Enter the Number of N: ");
            year =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Leap years from 1 to {year}:");

            for(int i=0; i < year; i++){
                if(i%400 == 0 || i%4==0){
                    Console.WriteLine($"{i} ");                
                }
            }
        }
    }
}