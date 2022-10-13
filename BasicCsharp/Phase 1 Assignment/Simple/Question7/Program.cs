using System;
namespace Question7{
    class Program{
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine($"Enter the Number : ");
            number =Convert.ToInt32(Console.ReadLine());

            if(number < 100){
                Console.WriteLine($"Less then 100");
            }else if(number>=100 && number <=200){
                Console.WriteLine($"Between 100 and 200");
            }else{
                Console.WriteLine($"Greater then 200");
            }
        }
    }
}