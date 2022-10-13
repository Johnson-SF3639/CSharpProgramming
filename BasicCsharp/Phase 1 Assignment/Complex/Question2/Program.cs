using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double fact=2, sum=0, value=0;
            Console.WriteLine($"Tailor Series : \nEnter the Terms");
            double terms = double.Parse(Console.ReadLine());
            
            for(int i=1; i<terms; i++){
                for(fact=1; fact < terms; fact++){
                    sum = fact*i;
                    value = sum + (fact*i);
                }
            }
            Console.WriteLine($"{value}");

        }
    }
}