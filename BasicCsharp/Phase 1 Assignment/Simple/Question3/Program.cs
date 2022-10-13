using System;
namespace Question3{
    class Program{
        public static void Main(string[] args)
        {
            float celsius, fahrenheit;
            Console.Write($"Enter the Celsius : ");
            celsius = float.Parse(Console.ReadLine());
            
            fahrenheit=celsius*(9/5)+32;

            Console.WriteLine($" Fahrenheit : {fahrenheit}");
        }
    }
}