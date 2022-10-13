using System;
namespace Question9{
    class Program{
        public static void Main(string[] args)
        {
            for(int i=0; i<4; i++){
                for(int j=0; j<7; j++){
                    if(i+j == 3 || i==3){
                        Console.Write("*");
                    }else if((i+j == 4 && i!=0) || (i+j == 5 && i!=0)){
                        Console.Write("*");
                    }else if((i+j == 6 && i!=0 && i!=1) || (i+j == 7 && i!=1)){
                        Console.Write("*");
                    }else{
                        Console.Write(" ");
                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}