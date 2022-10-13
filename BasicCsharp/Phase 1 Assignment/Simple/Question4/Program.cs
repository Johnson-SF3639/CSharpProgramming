using System;
namespace Question4{
    class Program{
        public static void Main(string[] args)
        {
            double  rate, usd, eur, cny;
            Console.Write($"Enter the Rate : ");
            rate = Convert.ToInt32(Console.ReadLine());
            
            usd= rate/81.96;
            eur= rate/78.74;
            cny= rate/11.37;

            Console.WriteLine($" Rate : {rate}");
            Console.WriteLine($" USD : {usd}");
            Console.WriteLine($" EUR : {eur}");
            Console.WriteLine($" CNY : {cny}");
        }
    }
}