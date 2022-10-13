using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            double radius, height, answer;
            Console.WriteLine("Enter the Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wnter the Height");
            height = Convert.ToInt32(Console.ReadLine());
            answer = 3.14 * Math.Pow(radius,2)*height; 
            Console.WriteLine($"Volume = {answer}");
        }
    }
}
