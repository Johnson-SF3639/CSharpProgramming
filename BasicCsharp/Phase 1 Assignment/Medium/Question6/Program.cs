using System;
namespace Question6{
    class Program{
        public static void Main(string[] args)
        {
            int[,] matrixArr1 =new int[3,3];
            int[,] matrixArr2 =new int[3,3];
            int[,] matrixArr3 =new int[3,3];
            Console.WriteLine($"Enter the 1st Array");
            for (int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    matrixArr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }   
            }
            Console.WriteLine($"Enter the 2st Array");
            for (int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    matrixArr2[i,j] = Convert.ToInt32(Console.ReadLine());
                }   
            }
            Console.WriteLine($"Added two Arrays");
            for (int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    matrixArr3[i,j] =matrixArr1[i,j]+matrixArr2[i,j] ;
                    Console.Write($"{matrixArr3[i,j]} ");
                }   
                Console.WriteLine();
            }
            
        }
    }
}