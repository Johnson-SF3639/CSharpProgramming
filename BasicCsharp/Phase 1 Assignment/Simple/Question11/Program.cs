using System;
namespace Question11{
    class Program{
        public static void Main(string[] args)
        {
            int value1, value2, total=1;
            Console.WriteLine($"Enter the Word X : ");
            value1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Word Y : ");
            value2 =Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<value2; i++){
                total = total*value1;
            }
            Console.WriteLine($"X power Y is : {total}");
            
        }
    }
}