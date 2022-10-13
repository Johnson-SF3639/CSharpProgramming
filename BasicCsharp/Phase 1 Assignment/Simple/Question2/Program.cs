using System;
namespace Question2{
    class Program{
        public static void Main(string[] args)
        {
            double area, radius, perimeter;
            Console.Write($"Enter the Radius : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14*(radius*radius);
            perimeter = 2*3.14*radius;

            Console.WriteLine($" Area : {area}");
            Console.Write($" Perimeter : {perimeter}");

        }
    }
}