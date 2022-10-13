using System;
namespace Question8{
    class Program{
        public static void Main(string[] args)
        {
            double number;
            Console.WriteLine($"Enter the Number : ");
            number =Convert.ToDouble(Console.ReadLine());

            if(number <= 10){
                Console.WriteLine($"Slow");
            }else if(number>10 && number <=50){
                Console.WriteLine($"Average");
            }else if(number>50 && number <=150){
                Console.WriteLine($"Fast");
            }else if(number>150 && number <=1000){
                Console.WriteLine($"Ultra Fast");
            }else{
                Console.WriteLine($"extremely fast");
            }
        }
    }
}