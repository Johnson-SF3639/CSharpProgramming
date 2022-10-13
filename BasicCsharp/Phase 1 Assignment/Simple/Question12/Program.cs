using System;
namespace Question12{
    class Program{
        public static void Main(string[] args)
        {
            int value1,count=0;
            Console.WriteLine($"Square the Odd Number (1 to 99) : ");

            for(int i=1; i<=99; i++){
                if(i%2==1){
                    count=count+(i*i);
                }                
            }
            Console.WriteLine($"{count}");
        }
    }
}