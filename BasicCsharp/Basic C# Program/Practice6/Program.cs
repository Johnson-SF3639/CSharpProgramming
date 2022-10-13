using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            double price, total;
            
            Console.WriteLine("Enter the Price amount :");
            price= Convert.ToInt64(Console.ReadLine());

            total=price+(price*0.18);
            
            Console.WriteLine("Price - " +price);
            Console.WriteLine("Total - " +total);
        }
    }
}