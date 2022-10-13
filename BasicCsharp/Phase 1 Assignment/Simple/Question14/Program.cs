using System;
namespace Question14{
    class Program{
        public static void Main(string[] args)
        {
            for(int i=1; i<=6; i++){
                for(int j=1; j<=i; j++){
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
            
        }
    }
}