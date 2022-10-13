using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            double action, area, periMeter, diameter, radius, choice;
            Console.WriteLine("1 = area of circle\n2 = Perimeter of circle\n3 = Diameter of circle\n");
            Console.WriteLine("Enter the Radius of circle : ");
            radius= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Choice(1, 2, 3): ");
            choice= Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1: {
                    area= 3.14 *radius*radius;
                    Console.WriteLine($"The area is : {area}");
                    break;
                }
                case 2 : {
                    periMeter=2*3.14*radius;
                    Console.WriteLine($"The Perimeter is : {periMeter}");
                    break;
                }
                case 3 : {
                    diameter= 2*radius;
                    Console.WriteLine($"The Diameter is : {diameter}");
                    break;
                }
            }
        }
    }
}