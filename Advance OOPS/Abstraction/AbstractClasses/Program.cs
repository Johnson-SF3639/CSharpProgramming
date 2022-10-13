using System;
namespace AbstractClasses{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n***** Abstract Class Application ******");

            Syncfusion syncfusion = new Syncfusion();
            syncfusion.Name="Developer";
            syncfusion.Salary(30);

            TCS tcs = new TCS();
            tcs.Name="Test Engineer";
            tcs.Salary(30);

            Console.WriteLine($"\n");
            
        }
    }
}