using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {
            int changer=4;
            for (int i=0; i<4; i++){
                
                for (int j=(changer-1); j>=0; j--){
                    Console.Write(" ");
                }
                for (int k=0; k<=i; k++){
                    Console.Write("* ");
                }
                Console.WriteLine("");
                changer--;
            }
        }
    }
}