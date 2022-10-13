using System;
namespace Question13{
    class Program{
        public static void Main(string[] args)
        {
            int value1;
            Console.WriteLine($"Enter the Number : ");
            value1 =Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=20; i++){
                Console.WriteLine($"{value1}*{i}= {value1*i}");
            }
            
        }
    }
}