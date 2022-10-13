using System;
namespace Practice8{
    class Program{
        public static void Main(string[] args)
        {
            double meter, centiMeter, miliMeter, inch, foot, mile;

            Console.WriteLine("Enter The Meter value :");
            meter= Convert.ToInt32(Console.ReadLine());

            centiMeter = meter*100;
            miliMeter =centiMeter*10;
            inch = 39.3*meter;
            foot = 12*meter;
            mile = 0.0006213715277778 * meter;
            
            Console.WriteLine("Meter "+meter);
            Console.WriteLine("CentiMeter "+centiMeter);
            Console.WriteLine("MiliMeter "+miliMeter);
            Console.WriteLine("Inch "+inch);
            Console.WriteLine("Foot "+foot);
            Console.WriteLine("Mile "+mile);
        }
    }
}
