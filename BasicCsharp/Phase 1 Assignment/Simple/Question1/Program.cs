using System;
namespace Question1{
    class Program{
        public static void Main(string[] args)
        {
            double inch, centiMeter;
            Console.Write($"Enter the Inch : ");
            inch = Convert.ToInt32(Console.ReadLine());
            centiMeter = 2.54*inch;
            Console.WriteLine($"Centimeter : "+centiMeter);
            

        }
    }
}