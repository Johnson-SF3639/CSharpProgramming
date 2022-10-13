using System;
namespace Practice9{
    class Program{
        public static void Main(string[] args)
        {
            double speed, time, distance;

            Console.WriteLine("Enter The Speed(Km/hr) :");
            speed= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Time(Sec) :");
            time= Convert.ToInt32(Console.ReadLine());

            distance=(int) speed* (int)time* (int)5/ (int)18;

            Console.WriteLine($"{distance} Meters");
        }
    }
}
