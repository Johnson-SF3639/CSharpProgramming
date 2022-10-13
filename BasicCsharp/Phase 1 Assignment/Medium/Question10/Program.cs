using System;
namespace Question10{
    class Program{
        public static void Main(string[] args)
        {
            for(int i=0; i<6; i++){
                for(int j=0; j<6; j++){
                    if(i == 0 || i == 5 || j == 0 || j==5){
                        Console.Write("*");
                    }else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}