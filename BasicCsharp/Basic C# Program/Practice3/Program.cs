using System;
namespace Pratices3{
    class program{
        public static void Main(string[] args)
        {
            double celsius, fahrenheit, kelvin;
            Console.WriteLine("Eneter the amount of Celsius");
            celsius = float.Parse(Console.ReadLine());

            kelvin = (celsius+ (int) 273.15);
            fahrenheit = (celsius *9/5) + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
        }
    }
}